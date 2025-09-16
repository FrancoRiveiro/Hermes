using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Mapers
{
    public class TransporteMPP
    {
        public static BE_Transporte FromSqlReader(SqlDataReader reader)
        {
            return new BE_Transporte(

            reader["Nombre"].ToString(),
            Convert.ToInt32(reader["Cupos"]),
            Convert.ToInt32(reader["ValorKM"])

             );

        }



        public static void ToSqlParameters(SqlCommand command, BE_Transporte transporte)
        {

            command.Parameters.AddWithValue("@Nombre", transporte.Nombre);
            command.Parameters.AddWithValue("@Cupos", transporte.Cupos);
            command.Parameters.AddWithValue("@ValorKM", transporte.ValorKM);

        }
    }
}
