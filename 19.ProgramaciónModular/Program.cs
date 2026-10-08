using System;


namespace _19.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            
            RealizarOperaciones(CapturarOpcion());

        }
        static float División()
        {
            Console.WriteLine("Ingrese el número 1 (dividendo):");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2 (divisor):");
            float numero2 = float.Parse(Console.ReadLine());

            while (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero. Ingrese un divisor válido:");
                numero2 = float.Parse(Console.ReadLine());
            }

            return numero1 / numero2;
        }
        static float Resta()
        {
            Console.WriteLine("Ingrese el número 1:");
            float numero1=float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            float numero2 = float.Parse(Console.ReadLine());

            return numero1-numero2; 

        }
        static float Multiplicación()
        {
            float numero = 0;
            float multiplicación = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                multiplicación *= numero;
                Console.WriteLine("Desea multiplicación más numeros, s: para continuar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicación;
        }
        static float Suma()
        {
            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea sumar más numeros, s: para continuar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion!= 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La suma de los números ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los números ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicación de los numeros ingresados es: {Multiplicación()}");
                        break;
                    case 4:
                        Console.WriteLine($"La división de los números ingresados es: {División()}");
                        break;


                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();

            }
        }
            static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("----------Menú--------------");
            Console.WriteLine("1. Suma                  2.Resta");
            Console.WriteLine("3. Multiplicación        4.División");
            Console.WriteLine("0. Salir");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese una opción del menú");
        }
    }
}
