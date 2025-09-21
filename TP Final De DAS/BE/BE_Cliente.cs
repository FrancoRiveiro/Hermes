using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class BE_Cliente:BE_Usuario
    {
        public BE_Cliente(string nombre, string apellido, int dni, string contraseña, string email, bool rol,int telefono) : base(nombre, apellido, dni, contraseña, email, false ,telefono)
        { 

           
        }
        public BE_Cliente(int id)
        {
            this.IdUsuario = id;
        }
    }
}
