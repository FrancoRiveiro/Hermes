using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Mapers
{
    public class ViajeMPP
    {
        public static BE_Viaje FromSqlReader(SqlDataReader reader)
        {
            return new BE_Viaje(

            reader["Destino"].ToString(),
            Convert.ToDateTime(reader["FechaSalida"]),
            Convert.ToDateTime(reader["FechaRetorno"]),
            //necesito objeto emprsa
            new BE_Empresa(Convert.ToInt32(reader["EmpresaID"])),
            //necesito objeto transporte
            new BE_Transporte(Convert.ToInt32(reader["TransporteID"])),
            Convert.ToInt32(reader["Km"])


             );

        }



        public static void ToSqlParameters(SqlCommand command, BE_Viaje viaje)
        {

            command.Parameters.AddWithValue("@Destino", viaje.Destino);
            command.Parameters.AddWithValue("@FechaSalida", viaje.FechaSalida);
            command.Parameters.AddWithValue("@FechaRetorno", viaje.FechaRetorno);
            command.Parameters.AddWithValue("@FechaRetorno", viaje.FechaRetorno);
            command.Parameters.AddWithValue("@Empresa", viaje.Empresa.IDEmpresa);
            command.Parameters.AddWithValue("@Transporte", viaje.Transporte.IdTransporte);
            command.Parameters.AddWithValue("@KM", viaje.KM);

        }
    }
}
}
