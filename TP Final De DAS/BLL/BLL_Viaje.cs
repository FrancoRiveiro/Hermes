using BE;
using DAL.Implemenaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Viaje
    {
        private ViajeBD dal;
        public BLL_Viaje()
        {
            dal = new ViajeBD();
        }
        public void Agregar(BE_Viaje entidad) 
        {
            if (string.IsNullOrEmpty(entidad.Destino) || entidad.Transporte != null || entidad.KM <= 0 || entidad.Empresa != null
                || entidad.FechaRetorno != null || entidad.FechaSalida != null )
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Agrear(entidad);
        }

        public void Eliminar(BE_Viaje id)
        {
            dal.Eliminar(id);
        }
        public void Modificar(BE_Viaje entidad)
        {
            if (string.IsNullOrEmpty(entidad.Destino) || entidad.Transporte != null || entidad.KM <= 0 || entidad.Empresa != null
                || entidad.FechaRetorno != null || entidad.FechaSalida != null)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Modificar(entidad);
        }
        public IEnumerable<BE_Viaje> ObtenerTodos()
        {
            return dal.listar();
        }
    }
}
