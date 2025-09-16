using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace Seguridad
{
    public class SesionManagger
    {
        // Variable estática para almacenar la instancia única de SesionManagger
        private static SesionManagger _instancia;

        // Variable para almacenar el usuario activo reandonly object se usa para evitar que se modifique directamente desde fuera de la clase
        public static readonly object _lock = new object();

        // Propiedad para acceder a la persona en sesión y evitar que sea modificada directamente desde fuera de la clase
        public BE_Usuario Usuario { get; private set; }


        // Constructor privado para evitar la creación de instancias desde fuera de la clase
        public static bool SesionActiva => _instancia != null;



        public static SesionManagger Instancia
        {
            // Propiedad estática para acceder a la instancia única de SesionManagger
            get
            {
                // Verifica si la instancia ya ha sido creada
                if (_instancia == null)
                {
                    throw new Exception("La sesión no ha sido iniciada. Por favor, inicie sesión primero.");
                }
                return _instancia;

            }
        }

        public static void IniciarSesion(BE_Usuario usuario)
        {
            lock (_lock)
            {
                if (_instancia == null)
                {
                    _instancia = new SesionManagger
                    { Usuario = usuario };

                }

            }
        }

        public static void CerrarSesion()
        {
            //la palabra lock asegura que solo un hilo pueda acceder a este bloque de código a la vez
            lock (_lock)
            {
                _instancia = null; // Elimina la instancia actual
            }
        }

    }
}
