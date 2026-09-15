using System;


namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Arreglos Unidimensionales - Vectores
            int[] numeros=new int[5];

            numeros[0] = 10;
            numeros[1] = 56;
            numeros[2] = 22;
            numeros[3] = 45;
            numeros[4] = 102;
            numeros[5] = 14;
            //numeros[5] = 14, No se puede almacenar porque es una posición que no existe
            Console.WriteLine($"El número almacenado en la posición 3 con índice 2 es: {numeros [2]}");

            //Otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] { 'A', '#', '&', 'b' };
            bool[] valoresVerdad = { true, false, false, true, true, false, false };

            //Recorrer para almacenar datos
            string[] nombres = new string[7];
            for (int i = 0; i<7;i++)
            {
                Console.WriteLine($"Ingrese el nombre para P{i + 1}: I{2}");
                nombres[i] = Console.ReadLine();
                
            }
            //Recorrer para recuperar
            for (int i = 0;i<nombres.Length;i++) 
            {
                Console.Write($"{nombres[i]} |");
            }*/

            /* int[] numeros = new int[100];

             for (int i = 0; i < numeros.Length; i++)
             {
                 numeros[i] = 10;
             }
             for (int i = 0; i < numeros.Length; i++)
             {
                 Console.WriteLine($"Posición {i}: {numeros[i]}");
             }*/

            double[] numeros = new double[10];
            double acumuladorSuma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingresa el número para la posición {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0;i < numeros.Length;i++)
            {
                acumuladorSuma += numeros[i];
            }

            double promedio = acumuladorSuma / numeros.Length;

            Console.WriteLine($"\nEl promedio de los 10 numeros ingresados es: {promedio}");
        }
    }
}
