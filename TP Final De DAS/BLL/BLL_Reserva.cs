using BE;
using DAL.Implemenaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Reserva
    {
        private ReservaBD dal;
        public BLL_Reserva()
        {
            dal = new ReservaBD();
        }
        public void Agregar(BE_Reserva entidad)
        {
            if (entidad.Cupos > 0|| entidad.Cliente != null || entidad.ViajeReservado != null )
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Agrear(entidad);
        }
        public void Eliminar(BE_Reserva id)
        {
            dal.Eliminar(id);
        }
        public void Modificar(BE_Reserva entidad) 
        {
            if (entidad.Cupos > 0 || entidad.Cliente != null || entidad.ViajeReservado != null)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Modificar(entidad);
        }
        public IEnumerable<BE_Reserva> ObtenerTodos() 
        {
            return dal.listar();
        }
    }
}
