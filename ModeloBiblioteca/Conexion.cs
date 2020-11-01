using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.Modelo
{
    public class Conexion
    {
        public static MySqlConnection MySQL { get; set; }

        public static void ObtenerConexion()
        {
            try {
            MySQL = new MySqlConnection("server = localhost; user = root1; database = libros; port = 3306; password = 1234");
            Console.WriteLine("conexión"); }
             catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido conectar \n" + ex);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }
        }

        public static List<Alumno> Mostrar()
        {
            MySQL.Open();
            List<Alumno> lista = new List<Alumno>();

            using (MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM alumnos"), MySQL))
            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Alumno
                    {
                        Registro = reader.GetInt32(0),
                        Dni = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Apellido1 = reader.GetString(3),
                        Apellido2 = reader.GetString(4)
                    });
                }
            }

            MySQL.Close();
            return lista;
        }

        public static void Eliminar(int buscarRegistro)
        {
            new MySqlCommand(string.Format("DELETE FROM alumnos WHERE registro={0}", buscarRegistro), MySQL).ExecuteNonQuery();
            MySQL.Close();
        }

        public static Alumno BuscarAlumno(String buscarDni)
        {
            MySQL.Open();
            Alumno miAlumno = new Alumno();
            String sentencia = "SELECT * FROM alumnos WHERE dni= @dni";
            MySqlCommand comando = new MySqlCommand(sentencia, MySQL);
            comando.Parameters.AddWithValue("@dni", buscarDni);
            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    miAlumno=(new Alumno
                    {
                        Registro = reader.GetInt32(0),
                        Dni = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Apellido1 = reader.GetString(3),
                        Apellido2 = reader.GetString(4)
                    });
                }
            }

            MySQL.Close();
            return miAlumno;
        }


        public static bool BuscarAlumnoPrestamos(int buscarRegistro)
        {
            MySQL.Open();
            string sentencia = "SELECT * FROM prestamos WHERE codAlumno= @codigoAlumno";
            MySqlCommand comando = new MySqlCommand(sentencia, MySQL);
            comando.Parameters.AddWithValue("@codigoAlumno", buscarRegistro);
            MySqlDataReader prestamosReader = comando.ExecuteReader();

            if (prestamosReader.HasRows)
            {
                prestamosReader.Close();
                return false;

            }
            else if (!prestamosReader.HasRows)
            {
                prestamosReader.Close();
                return true;

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
                return false;

            }
            MySQL.Close();
        }
    }
}
