using System;


namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Ciclo Do While 
            int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");

            int contador = 1;
            string respuesta;
            do
            {
                Console.WriteLine("Ingresa un número para generar su tabla de multiplicar:");
                int numero = int.Parse(Console.ReadLine());
                
                
                Console.WriteLine($"\n-- Tabla del {numero} ---");
                while (contador <= 10)
                {
                    int resultado = numero * contador;
                    Console.WriteLine($"{numero} x {contador} = {resultado}");
                    contador++;
                }
                contador = 1;
                Console.WriteLine("\n¿Deseas generar otra tabla de multiplicar? (Si o no):");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "si" );
            
            Console.WriteLine("Programa finalizado"); */

            Console.WriteLine("Numeros primo hasta del 1 al 100: \n");

            int numeroActual = 2; 

            while(numeroActual <= 100)
            {
                bool esPrimo = true;
                int divisor = 2;

                while (divisor < numeroActual)
                {
                    if (numeroActual % divisor == 0)
                    {
                        esPrimo = false;
                    }
                    divisor++;  
                }

                if (esPrimo)
                {
                    Console.WriteLine($"{numeroActual}");
                }
                numeroActual++;
            }
            Console.WriteLine("\n\nPresiona cualquier tecla para salir");
            Console.ReadKey();
            
        }
    }
}
