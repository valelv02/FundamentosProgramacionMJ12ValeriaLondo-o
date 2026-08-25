using System;


namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1. Escribir un algoritmo que permita generar los primeros 5 numeros enteros positivos y realizar y mostrar su uma.
            int contador = 1;
            int acumulador = 1;

            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }

            Console.WriteLine($"La suma de los cinco primeros numeros es: {acumulador}");*/

            //2.Crear un algortimo que permita calcular la factorial de un número dado por el usuario. (5! =1*2*3*4*5)
            Console.WriteLine("Por favor ingresa un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());

            int contador = 1;
            int acumulador = 1; 

            while(contador < numero)
            {
                contador++;
                acumulador = acumulador * contador;
            }
            Console.WriteLine($"El factorial de {numero} es: {acumulador}");
        }
    }
}
