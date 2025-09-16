using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class BE_Administrador: BE_Usuario
    {
        public BE_Administrador(string nombre, string apellido, int dni, string contraseña, string email, bool rol,int telefono) : base(nombre, apellido, dni, contraseña, email, true ,telefono)
        {
           

        }
    }
}
