using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Consola
{
    internal class Program
    {
        const string user = "admin";
        const string password = "admin";
        static void Main(string[] args)
        {
            //declaración de variables
            string userInp;
            string passwordInp;
            int attemps = 3;


            //Ingreso de credenciales

            Console.Write("Ingrese su usuario: ");
            userInp = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            passwordInp = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Iniciando sesión...");
            Thread.Sleep(3000);
            Console.Clear();


            //Validación de credenciales
            while (userInp != user || passwordInp != password)
            {
                Console.Clear();
                Console.Write("Usuario o contraseña incorrectos, vuelva a intentarlo (" + (attemps-1) + " intentos restantes)\n");
                attemps--; //decremento de intentos, no inicializado en 0 para mostrar en pantalla los intentos restantes correctamente
                if (attemps == 0)
                {
                    Console.Write("Ha superado el número de intentos permitidos (3), cerrando programa...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
                }
                Console.Write("Ingrese su usuario: ");
                userInp = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                passwordInp = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Iniciando sesión...");
                Thread.Sleep(3000);
                Console.Clear();
            }


            //inicio de sesión existosa
            Console.Clear();
            Console.WriteLine("Iniciando sesión...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Sesión Iniciada con éxito! Bienvenido '" + user + "'!");
        }
    }
}
