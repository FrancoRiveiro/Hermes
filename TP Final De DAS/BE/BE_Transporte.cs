using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Transporte
    {
        public BE_Transporte(string nomb, int cupos, int km)
        {
            Nombre = nomb;
            Cupos = cupos;
            this.ValorKM = km;
        }

        private int _idTransporte;

        public int IdTransporte
        {
            get { return _idTransporte; }
            set { _idTransporte = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private int _cupos;

        public int Cupos
        {
            get { return _cupos; }
            set { _cupos = value; }
        }
        private int _valorKM;

        public int ValorKM
        {
            get { return _valorKM; }
            set { _valorKM = value; }
        }

    }
}
