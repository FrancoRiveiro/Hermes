using BE;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL.Implemenaciones
{
    public class ReservaBD : IABM<BE_Reserva>, IListar<BE_Reserva>
    {
        private readonly string connectionString;
        public ReservaBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }
        public void Agrear(BE_Reserva entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE_Reserva id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BE_Reserva> listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(BE_Reserva entidad, params object[] datos)
        {
            throw new NotImplementedException();
        }
    }
}
