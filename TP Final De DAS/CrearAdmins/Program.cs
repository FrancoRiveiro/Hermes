using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad;


namespace CrearAdmins
{
    //Uso este pequelo programa para hashear contraseñas y asi poder insertarlos automaticamente en la abse de datos (a los admins)
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese la contraseña que desea hashear:");
            string contraseñaPlana = Console.ReadLine();

            // Llama a tu método de hasheo
            string contraseñaHasheada = ContraseñaHasher.GenerarHash(contraseñaPlana);

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"Contraseña en texto plano: {contraseñaPlana}");
            Console.WriteLine($"Contraseña hasheada: {contraseñaHasheada}");
            Console.WriteLine("\n¡Copia la contraseña hasheada y pégala en tu base de datos!");

            // Espera a que el usuario presione una tecla antes de cerrar
            Console.ReadKey();
        }
    }
}
