using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class BE_Viaje
    {
        public BE_Viaje(string dest, DateTime salida, DateTime retorno, BE_Empresa emp, BE_Transporte transp, int km)
        {
           
            this.Destino = dest;
            this.FechaSalida = salida;
            this.FechaRetorno = retorno;
            this.Empresa = emp;
            this.Transporte = transp;
            this.CuposTotales = transp.Cupos;
            this.KM = km;
            this.Costo = this.CalcularCostoTotal();
        }

        public BE_Viaje(int id)
        {
            this.IDViaje = id;
        }

        //propiedades

        string NombreEmpresa => Empresa?.Nombre;
        string NombreTransporte => Transporte?.Nombre;
        private int _cuposTotales;

        public int CuposTotales
        {
            get { return _cuposTotales; }
            set { _cuposTotales = value; }
        }

        private BE_Empresa _empresa;

        public BE_Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        private int _IDViaje;

        public int IDViaje
        {
            get { return _IDViaje; }
            set { _IDViaje = value; }
        }

        private DateTime _fechaSalida;

        public DateTime FechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }

        private DateTime _fechaRetorno;

        public DateTime FechaRetorno
        {
            get { return _fechaRetorno; }
            set { _fechaRetorno = value; }
        }

        private string _destino;

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        private BE_Transporte _transporte;

        public BE_Transporte Transporte
        {
            get { return _transporte; }
            set { _transporte = value; }
        }
        private int _km;

        public int KM
        {
            get { return _km; }
            set { _km = value; }
        }

        private int _cuposDisponibles;

        public int CuposDisponibles
        {
            get { return _cuposDisponibles; }
            set { _cuposDisponibles = value; }
        }

        private int _costo;

        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }




        
        public int CalcularCostoTotal()
        {
            int total = KM * Transporte.ValorKM;
            return total;
        }










    }
}
