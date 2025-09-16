using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Mapers
{
    public class EmpresaMPP
    {
        public static BE_Empresa FromSqlReader(SqlDataReader reader)
        {
            return new BE_Empresa(
            
            reader["Nombre"].ToString(),
            Convert.ToInt32(reader["CodPostal"]),
            reader["Direccion"].ToString()
            
             );

        }
           
        

        public static void ToSqlParameters(SqlCommand command, BE_Empresa empresa)
        {

            command.Parameters.AddWithValue("@Nombre", empresa.Nombre);
            command.Parameters.AddWithValue("@CodPostal", empresa.CodPostal);
            command.Parameters.AddWithValue("@Direccion", empresa.Direccion);
            
        }
    }
}
