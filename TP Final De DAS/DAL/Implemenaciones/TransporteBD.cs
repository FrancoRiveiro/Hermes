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
    public class TransporteBD : IABM<BE_Transporte>, IListar<BE_Transporte>
    {
        private readonly string connectionString;
        public TransporteBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }
        public void Agrear(BE_Transporte entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE_Transporte id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BE_Transporte> listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(BE_Transporte entidad, params object[] datos)
        {
            throw new NotImplementedException();
        }
    }
}
