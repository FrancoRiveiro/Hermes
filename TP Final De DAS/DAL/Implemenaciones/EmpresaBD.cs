using BE;
using DAL.Interfaces;
using MPP.Mapers;
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
            string query = " INSERT INTO Empresa (Nombre, CodPostal, Direccion) VALUES (@Nombre,@CodPostal , @Direccion)";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con)) 
                {

                    EmpresaMPP.ToSqlParameters(comm, entidad);
                    con.Open();
                    comm.ExecuteNonQuery();
                }

            }
        }

        public void Eliminar(BE_Empresa id)
        {
            string query = "DELATE FROM Empresa WHERE IdEmpresa = @IDEmpresa";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {

                using (SqlCommand comm = new SqlCommand(query, con)) 
                {
                    comm.Parameters.AddWithValue("@IDEmpresa", id.IDEmpresa);
                    con.Open();
                    comm.ExecuteNonQuery();

                }
            }

        }

      

        public void Modificar(BE_Empresa entidad, params object[] datos)
        {
            string query = "UPDATE Empresa Set Nombre = @Nombre ,  CodPostal = @CodPostal, Direccion = @Direccion WHERE IdEmpresa =  @IDEmpresa ";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con)) 
                {
                    EmpresaMPP.ToSqlParameters(comm, entidad);
                    con.Open();
                    comm.ExecuteNonQuery();

                }
            
            }
        }
      
        public IEnumerable<BE_Empresa> listar()
        {
            List<BE_Empresa> empresa = new List<BE_Empresa>();

            string query = "SELECT * FROM Empresa";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con)) 
                {
                    con.Open();

                    using (SqlDataReader redear = comm.ExecuteReader()) 
                    {
                     while (redear.Read()) 
                        {
                            empresa.Add(EmpresaMPP.FromSqlReader(redear));
                        }
                    }
                
                }
            
            }

            return empresa;
        }
    }
}
