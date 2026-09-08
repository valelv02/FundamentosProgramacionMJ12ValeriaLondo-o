using System;

namespace _14.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Ingresa el número inicial del rango:");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el número final del rango:");
            int fin = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMúltiplos de 5 entre {inicio} y {fin}:");

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
