using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    static class Helper
    {
        /// <summary>
        /// Solicita un entero y valida que se pueda convertir
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        internal static int PedirNumero(string mensaje)
        {
            int salida;
            Console.Write(mensaje + ": ");
            while (!int.TryParse(Console.ReadLine(), out salida))
                Console.Write("El valor ingresado no es válido.\nIngrese un nuevo valor: ");

            return salida;
        }

        /// <summary>
        /// Solicita un entero y valida también que se encuentre entre min y max
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static int PedirNumero(string mensaje, int min, int max)
        {
            int salida;
            Console.Write(mensaje + ": ");
            while (!int.TryParse(Console.ReadLine(), out salida))
                Console.Write("El valor ingresado no es válido, debe encontrarse entre {0} y {1}." +
                    "\nIngrese un nuevo valor: ", min, max);

            return salida;
        }

        /// <summary>
        /// Solicita un double y valida que se pueda convertir
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        internal static double PedirDouble(string mensaje)
        {
            double salida;
            Console.Write(mensaje + ": ");
            while (!double.TryParse(Console.ReadLine(), out salida))
                Console.Write("El valor ingresado no es válido. \nIngrese un nuevo valor: ");

            return salida;
        }

        /// <summary>
        /// Solicita un double y valida que el mismo
        /// se encuentra entre los valores min y max
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static double PedirDouble(string mensaje, int min, int max)
        {
            double salida;
            Console.Write(mensaje + ": ");
            while (!double.TryParse(Console.ReadLine(), out salida))
                Console.Write("El valor ingresado no es válido, debe encontrarse entre {0} y {1}." +
                    "\nIngrese un nuevo valor: ", min, max);

            return salida;
        }

        /// <summary>
        /// Solicita un string y valida que el mismo no sea null o vacío
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        internal static string PedirPalabra(string mensaje)
        {
            string salida;
            do
            {
                Console.Write(mensaje + ": ");
                salida = Console.ReadLine();
                if (string.IsNullOrEmpty(salida))
                    Console.WriteLine("\nEl campo no puede ser vacío." +
                        "\nPor favor, ingrese un nuevo valor.\n");
            } while (string.IsNullOrEmpty(salida));

            return salida;
        }

        /// <summary>
        /// Solicita dia mes y año y devuelve una fecha
        /// </summary>
        /// <returns></returns>
        public static DateTime PedirFecha()
        {
            int numero, numero2, numero3;
            numero = PedirNumero("Ingrese un día", 1, 31);
            numero2 = PedirNumero("Ingrese un mes", 1, 12);
            numero3 = PedirNumero("Ingrese un año", 1, 2020);
            DateTime fecha = new DateTime(numero3, numero2, numero);
            return fecha;
        }

        public static string PedirFechaString(string mensaje)
        {
            Console.WriteLine(mensaje);
            string fecha = "";
            fecha += PedirNumero("Ingrese un día", 1, 31) + "/";
            fecha += PedirNumero("Ingrese un mes", 1, 12) + "/";
            fecha += PedirNumero("Ingrese un año", 1, 2020); 
            return fecha;
        }

        public static bool PedirPresente()
        {
            string salida;
            do
            {
                Console.Write("Esta presente el alumno? Ingrese S o N: ");
                salida = Console.ReadLine();
                if (string.IsNullOrEmpty(salida))
                    Console.Write("\nEl campo no puede ser vacío." +
                        "\nPor favor, ingrese un nuevo valor.\n");
            } while (string.IsNullOrEmpty(salida) || (salida.ToUpper() != "S" && salida.ToUpper() != "N"));

            return salida.ToLower() == "s";
        }

        /// <summary>
        /// Solicita ingreso de S o N para ver si el usuario quiere continuar 
        /// lo que se esta realizando
        /// </summary>
        /// <returns></returns>
        internal static string QuiereReintentar()
        {
            string salida;
            do
            {
                Console.Write("Desea reintentar? Ingrese S o N: ");
                salida = Console.ReadLine();
                if (string.IsNullOrEmpty(salida))
                    Console.Write("\nEl campo no puede ser vacío." +
                        "\nPor favor, ingrese un nuevo valor.\n");
            } while (string.IsNullOrEmpty(salida) || (salida.ToUpper() != "S" && salida.ToUpper() != "N"));

            return salida.ToUpper();
        }
        internal static void Continuar()
        {
            Console.Write("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}