using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNota.Modelos
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Docente() { }
        public Docente(string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}
