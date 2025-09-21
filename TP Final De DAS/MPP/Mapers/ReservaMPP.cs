using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Mapers
{
    public class ReservaMPP
    {
        public static BE_Reserva FromSqlReader(SqlDataReader reader)
        { 
            return new BE_Reserva(

            Convert.ToInt32(reader["Cupos"]),
            //necesito objeto cliente
            cli: new BE_Cliente(Convert.ToInt32(reader["IdCliente"])),
            //necesito objeto viaje
            viaje: new BE_Viaje(Convert.ToInt32(reader["IdViaje"]))

         );

    }



    public static void ToSqlParameters(SqlCommand command, BE_Reserva reserva)
        {

            command.Parameters.AddWithValue("@Cupos", reserva.Cupos);
            command.Parameters.AddWithValue("@Cliente", reserva.Cliente.IdUsuario);
            command.Parameters.AddWithValue("@Viaje", reserva.ViajeReservado.IDViaje);

        }
    }
}

