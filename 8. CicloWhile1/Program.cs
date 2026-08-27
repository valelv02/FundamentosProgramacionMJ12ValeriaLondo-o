using System;

namespace _8.CicloWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int acumulador = 0;

            Console.WriteLine("Ingresa un número entero positivo para sumar (o un negativo para salir):");
            int numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                acumulador += numero;

                Console.WriteLine("Ingresa otro número:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma total de los números positivos ingresados es: {acumulador}");
        }
    }
}