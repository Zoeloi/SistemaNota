using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNota.Modelos
{
    public class Carrera
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Carrera() { }
        public Carrera(string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }



    }
}
