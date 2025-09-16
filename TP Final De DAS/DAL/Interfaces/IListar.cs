using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public  interface IListar <out t> where t : class
    { 


        IEnumerable<t> listar();
    }
}
