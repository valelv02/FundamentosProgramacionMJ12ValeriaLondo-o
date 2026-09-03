using System;


namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numcuenta;
            float saldo;
            int contador = 0;
            float acumulador = 0;
            string respuesta;
            float promedio;
            do
            {
                contador++;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta");
                numcuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = float.Parse(Console.ReadLine());
                acumulador += saldo;
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcuenta}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcuenta}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted no es apto para el crédito");
                }
                contador = 1;
                Console.WriteLine("\nDesea continuar (Si o no):");
                respuesta = Console.ReadLine().ToLower();
                
                
            }
            while(respuesta == "si");
            Console.WriteLine($"Cantidad de usuarios:{contador}");
            promedio = acumulador / contador;
            Console.WriteLine($"El promedio en los saldos fue:{promedio}");
        }
    }
}
