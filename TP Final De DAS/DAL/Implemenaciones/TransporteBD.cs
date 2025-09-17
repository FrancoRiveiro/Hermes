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
    public class TransporteBD : IABM<BE_Transporte>, IListar<BE_Transporte>
    {
        private readonly string connectionString;
        public TransporteBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }
        public void Agrear(BE_Transporte entidad)
        {
        string query = "INSERT INTO Transporte (Nombre, Cupos, km) VALUES (@Nombre , @Cupos, @km)";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con)) 
                {
                TransporteMPP.ToSqlParameters(comm , entidad);              
                    con.Open();
                    comm.ExecuteNonQuery();

                }
            }
        
        }

        public void Eliminar(BE_Transporte id)
        {
            string query = "DELETE FROM Transporte WHERE IdTransporte = @IDTransporte";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query,con )) 
                {
                    comm.Parameters.AddWithValue("@IDTransporte", id.IdTransporte);
                    con.Open();
                    comm.ExecuteNonQuery();

                }
            }
        }

        public IEnumerable<BE_Transporte> listar()
        {
            List<BE_Transporte> transportes = new List<BE_Transporte>();

            string QUERY = "SELECT * FROM Transporte";

            using (SqlConnection con = new SqlConnection(connectionString))

            {

                using (SqlCommand comm = new SqlCommand(QUERY, con))
                {
                    con.Open();
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            transportes.Add(TransporteMPP.FromSqlReader(reader));

                        }
                    }
                }
            }

            return transportes; 
        }

        public void Modificar(BE_Transporte entidad, params object[] datos)
        {
            string query = "UPDATE Transporte SET Nombre = @Nombre , Cupos = @Cupos , km = @km WHERE IdTransporte = @IDTranposte";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con)) 
                {
                   TransporteMPP.ToSqlParameters(comm, entidad);
                    con.Open();
                    comm.ExecuteNonQuery();

                }
            
            }


        }
    }
}
