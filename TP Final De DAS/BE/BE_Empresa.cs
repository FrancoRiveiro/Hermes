using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Empresa
    {
        private int _idEmpresa;

        public int IDEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _CodPostal;
        public int CodPostal
        {
            get { return _CodPostal; }
            set { _CodPostal = value; }
        }


        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }


        //constructor
        public BE_Empresa( string Nom, int codPos, string direccion)
        {
            
            this.Nombre = Nom;
            this.CodPostal = codPos;
            this.Direccion = direccion;
        }
    }
}
