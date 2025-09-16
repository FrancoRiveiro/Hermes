using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Reserva
    {
        public BE_Reserva(int id, int cupos, BE_Cliente cli, BE_Viaje viaje)
        {
            this.idReserva = id;
            this.Cupos = cupos;
            this.Cliente = cli;
            this.ViajeReservado = viaje;
            this.CostoTotal = (viaje != null ? viaje.CalcularCostoTotal() : 0) * cupos;

        }
        private int idReserva;

        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        private int _cupos;

        public int Cupos
        {
            get { return _cupos; }
            set { _cupos = value; }
        }

        private BE_Cliente _cliente;

        public BE_Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        private BE_Viaje _viaje;

        public BE_Viaje ViajeReservado
        {
            get { return _viaje; }
            set { _viaje = value; }
        }

        private int _costoTotal;

        public int CostoTotal
        {
            get { return _costoTotal; }
            set { _costoTotal = value; }
        }


    }
}
