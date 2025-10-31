using SistemaNota.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNota.Controlador
{
    //Crear ,Leer ,Actualizar,Eliminar 
    //Crud
    public class DocenteController
    {
        private List<Docente> docentes = new List<Docente>();


        // Crear
        /// <summary>
        /// Obtiene todas las carrera
        /// </summary>
        /// <returns></returns>
        public List<Docente> GetDocente()
        {
            return docentes;
        }/// Leer
         /// <summary>
         /// Buscar un elemento y retorna los registros encontrados 
         /// </summary>
         /// <param name="dato"></param>
         /// <returns></returns>
        public List<Docente> GetDocente(string dato)

        {

            return docentes.FindAll(c => c.Nombre.Contains(dato));

        }
        /// <summary>
        /// Buscar para eliminar
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Docente GetDocente(string nombre, string codigo)
        {
            Docente docente = docentes.Find(c => c.Codigo == codigo);
            return docente;
        }
        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Docente docente = new Docente(nombre, codigo);
                docentes.Add(docente);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean Eliminar(string nombre, string codigo)
        {
            Docente docente = GetDocente(nombre, codigo);
            if (docente == null)
            {
                return false;
            }
            docentes.Remove(docente);
            return true;

        }

    }
}
