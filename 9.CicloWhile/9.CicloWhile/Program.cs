using System;


namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Por favor ingresa la cantidad de numeros que vas a introducir:");
            int cantidadTotal = int.Parse(Console.ReadLine());

            int contador = 0;
            int mayoresQueCero = 0;
            int menoresQueCero = 0;
            int igualesACero = 0;

            while(contador < cantidadTotal)
            {
                Console.WriteLine($"Ingrese el número {contador + 1}:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    mayoresQueCero++;
                }
                else if (numero < 0)
                {
                    menoresQueCero ++;
                }
                else
                {
                    igualesACero++;
                }
                contador ++;
            }
            Console.WriteLine($"Mayores que 0:{mayoresQueCero}, menores que 0:{menoresQueCero}, iguales a 0:{igualesACero}");*/

            //2.
            Console.WriteLine("Por favor ingresa el número n:");
            int n = int.Parse(Console.ReadLine());

            int contador = 1;
            int contadorPares = 0;

            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de numeros pares del 1 al {n} es; {contadorPares}");
        }
    }
}
