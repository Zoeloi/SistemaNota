
using SistemaNota.Modelos;
using System;
using System.Collections.Generic;

namespace SistemaNota.Controlador
{
    //Crear ,Leer ,Actualizar,Eliminar 
    //Crud
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();

        // Crear
        /// <summary>
        /// Obtiene todas las carrera
        /// </summary>
        /// <returns></returns>
        public List<Carrera> GetCarrera()
        {
            return carreras;
        }
        /// Leer
        /// <summary>
        /// Buscar un elemento y retorna los registros encontrados 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public List<Carrera> GetCarrera(string dato)

        {
            
          return carreras.FindAll(c => c.Nombre.Contains(dato));

        }
        /// <summary>
        /// Buscar para eliminar
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>

        public  Carrera GetCarrera (string nombre,string codigo)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }


        
        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(nombre, codigo);
                carreras.Add(carrera);
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public Boolean Eliminar(string nombre, string codigo)
        {
            Carrera carrera = GetCarrera(nombre, codigo);
            if (carrera == null)
            {
                return false;
            }
            carreras.Remove(carrera);
            return true;

        }


    }
}
