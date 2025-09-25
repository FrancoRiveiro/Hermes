using BE;
using DAL.Implemenaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Transporte
    {
        private TransporteBD dal;
        public BLL_Transporte()
        {
            dal = new TransporteBD();
        }
        public void Agregar(BE_Transporte entidad) 
        {
            if (string.IsNullOrEmpty(entidad.Nombre) || entidad.Cupos > 0 || entidad.ValorKM > 0)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Agrear(entidad);
        }
        public void Eliminar(BE_Transporte id)
        {
            dal.Eliminar(id);
        }
        public void Modificar(BE_Transporte entidad)
        {
            if (string.IsNullOrEmpty(entidad.Nombre) || entidad.Cupos > 0 || entidad.ValorKM > 0)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Modificar(entidad);
        }
        public IEnumerable<BE_Transporte> ObtenerTodos() 
        {
            return dal.listar();
        }
    }
}
