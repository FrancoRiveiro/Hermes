using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DAL.Interfaces;

namespace DAL.Implemenaciones
{
    public class ViajeBD : IABM<BE_Viaje>, IListar<BE_Viaje>
    {
        private readonly string connectionString;

        public ViajeBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }

        public void Agrear(BE_Viaje entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE_Viaje id)
        {
            throw new NotImplementedException();
        }

   

        public void Modificar(BE_Viaje entidad, params object[] datos)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BE_Viaje> listar()
        {
            throw new NotImplementedException();
        }
    }
}
