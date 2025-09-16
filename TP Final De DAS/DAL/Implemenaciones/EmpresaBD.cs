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
    public class EmpresaBD : IABM<BE_Empresa>, IListar<BE_Empresa>
    {
        private readonly string connectionString;
        public EmpresaBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }
        public void Agrear(BE_Empresa entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE_Empresa id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BE_Empresa> listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(BE_Empresa entidad, params object[] datos)
        {
            throw new NotImplementedException();
        }
    }
}
