using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Modelo
{
    public class Alumno
    {
        public int Registro { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public Alumno(int registro,
                      string dni,
                      string nombre,
                      string apellido1,
                      string apellido2)
        {
            Registro = registro;
            Dni = dni;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
        }

        public Alumno()
        { }
    }
}
