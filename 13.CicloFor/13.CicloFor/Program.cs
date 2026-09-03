using System;


namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Ciclo For
             int acumulador = 0;

             for (int contador = 1; contador <= 5; contador++)
             {
                 acumulador += contador;
             }
             Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/

            Console.WriteLine("Ingrese un número para calcular su factorial");
            int numero = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");

            Console.WriteLine("\nPresiona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
