using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.VistaMenu;
using Biblioteca.VistaListaAlumnos;
using Biblioteca.VistaBuscarEliminar;
using Biblioteca.Modelo;
using System.Windows.Forms;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace Biblioteca.Controlador
{
    public class Controlador
    {
		MenuPrincipal menu = null;
        Buscar buscar = new Buscar();
        Lista alumnos = new Lista();
		public static void Connectar() => Conexion.ObtenerConexion();
		public static List<Alumno> MostrarAlumnos() => Conexion.Mostrar();

        public static void EliminarAlumno(int buscarRegistro) => Conexion.Eliminar(buscarRegistro);

		public Alumno BuscarAlumno(String buscarDni) => Conexion.BuscarAlumno(buscarDni);

		public bool BuscarAlumnoPrestamos(int buscarRegistro) => Conexion.BuscarAlumnoPrestamos(buscarRegistro);
		public Controlador()
		{
			try
			{ 
				menu = new MenuPrincipal();
				ListenersMenu();
				menu.ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Error al abrir la ventana principal: ");
			}

		}

		private void VentanaAlumnos()
		{
			try
			{
				alumnos = new Lista();
				ListenersLista();
				CargarDatosAlumnos();
				alumnos.ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Error al abrir la ventana Alumnos: ");
			}

		}

		private void CargarDatosAlumnos() {
			Connectar();
            try { 
			alumnos.viewAlumnos.DataSource = MostrarAlumnos();
			}
			catch (SqlNullValueException e)
			{
				MessageBox.Show("El valor es nulo \n" + e);
			}
			catch (InvalidOperationException e)
			{
				MessageBox.Show("La operación no es válida \n" + e);
			}
			catch (NotSupportedException e)
			{
				MessageBox.Show("el método no está soportado \n" + e);
			}
			catch (MySqlException e)
			{
				MessageBox.Show("ha habido un error con la obtencion de datos SQL \n" + e);
			}
			catch (Exception e)
			{
				MessageBox.Show("Ha ocurrido un error \n" + e);
			}
		}

		private void CerrarAlumnos()
		{
			alumnos.Close();
		}

		private void VentanaBuscar()
		{
			try
			{
				buscar = new Buscar();
				ListenersBuscar();
				Connectar();
				buscar.clickBoton += buscar_clickBoton;
				buscar.ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Error al abrir la ventana para buscar alumnos");
			}

		}

		public void buscar_clickBoton(int valor)
		{
			if (valor == 1)
			{
				
				 Alumno miAlumno = BuscarAlumno(buscar.GetTextDni());

				if (miAlumno.Registro > 0)
				{
					buscar.setTextRegistro(miAlumno.Registro.ToString());
					buscar.setTextNombre(miAlumno.Nombre.ToString());
					buscar.setTextApellido1(miAlumno.Apellido1.ToString());
					buscar.setTextApellido2(miAlumno.Apellido2.ToString());
					buscar.BtnEliminar.Enabled = true;
				}
				else
				{
					MessageBox.Show("El alumno no se encuentra en la base de datos, intentalo de nuevo");
					Limpiar();
				}

			}
			else if (valor == 2)
			{
				if (BuscarAlumnoPrestamos(Int32.Parse(buscar.GetTextRegistro())))
				{
					MensajeEliminarUsuario();
				}
				else
				{
					MessageBox.Show("El alumno tiene un prestamo, no puede ser borrado");
					Limpiar();
				}
			}
			else if (valor == 3)
			{
				buscar.Close();
			}
		}

		private void MensajeEliminarUsuario()
		{
			const string mensaje = "Está seguro de querer eliminar este alumno?";
			const string captura = "Eliminar alumno";
			var result = MessageBox.Show(mensaje, captura,
										 MessageBoxButtons.OKCancel,
										 MessageBoxIcon.Question);

			if (result == DialogResult.OK)
			{
				EliminarUsuario();
			}
		}

		private void EliminarUsuario()
		{
			EliminarAlumno(Int32.Parse(buscar.GetTextRegistro()));
			MessageBox.Show("El alumno ha sido borrado");
			Limpiar();
		}
		
		private void Limpiar()
		{
			buscar.setTextDni("");
			buscar.setTextRegistro("");
			buscar.setTextNombre("");
			buscar.setTextApellido1("");
			buscar.setTextApellido2("");
			buscar.BtnEliminar.Enabled = false;
		}

		private void CerrarBuscar()
		{
			buscar.Close();
		}


		private void cerrar()
		{
			const string Mesaje = "Está seguro de querer salir de la aplicación?";
			const string captura = "Confirmación";
			var result = MessageBox.Show(Mesaje, captura,
										 MessageBoxButtons.OKCancel,
										 MessageBoxIcon.Question);

			if (result == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void ListenersMenu()
		{
			menu.BtnSalir.Click += (sender, args) => { cerrar(); };
			menu.BtnAlumno.Click += (sender, args) => { VentanaAlumnos(); };
			menu.BtnBuscar.Click += (sender, args) => { VentanaBuscar(); };
		}

		private void ListenersLista()
		{
			alumnos.Button1.Click += (sender, args) => { CerrarAlumnos(); };
		}

		private void ListenersBuscar()
		{
			buscar.BtnMenu.Click += (sender, args) => { CerrarBuscar(); };
		}

	}
}
