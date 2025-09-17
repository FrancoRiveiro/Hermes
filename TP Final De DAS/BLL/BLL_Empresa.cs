using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DAL.Implemenaciones;
namespace BLL
{
    public  class BLL_Empresa
    {

        private EmpresaBD dal;
        public BLL_Empresa()
        {
            dal  = new EmpresaBD();
        }

        public void  Agregar(BE_Empresa entidad)
        {
            if (string.IsNullOrEmpty(entidad.Nombre)|| string.IsNullOrEmpty(entidad.Direccion) || entidad.CodPostal <= 0)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Agrear(entidad);
        }

        public  void Eliminar(BE_Empresa id)
        {
            dal.Eliminar(id);
        }


        public  void Modificar(BE_Empresa entidad)
        {
            if (string.IsNullOrEmpty(entidad.Nombre) || string.IsNullOrEmpty(entidad.Direccion) || entidad.CodPostal <= 0)
            {
                throw new ArgumentException("No se aceptan campos vacíos o inválidos.");
            }
            dal.Modificar(entidad);
        }

        public IEnumerable<BE_Empresa> ObtenerTodos()
        {
            return dal.listar();
        }
    }
}
