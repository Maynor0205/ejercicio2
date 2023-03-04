using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2.models
{
    internal class Empleado
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string foto { get; set; }
    }
}
