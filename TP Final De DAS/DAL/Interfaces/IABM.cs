using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public  interface IABM <in t > where t : class
    {   

        void Agrear(t entidad );


        void Eliminar (t id);


        void Modificar(t entidad, params object[] datos);


    }
}
