using System;


namespace Parcial_2_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double totalVenta = 0;

            
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"Ingresa el valor base del producto {i}:");
                double valorBase = double.Parse(Console.ReadLine());

                double porcentajeIva = 0;

                if (valorBase > 10000)
                {
                    porcentajeIva = 0.15;
                }
                else if (valorBase >= 5000)
                {
                    porcentajeIva = 0.17;
                }
                else
                {
                    porcentajeIva = 0.19;
                }

                double valorIva = valorBase * porcentajeIva;
                double subtotal = valorBase + valorIva;

                totalVenta += subtotal;

                Console.WriteLine($"IVA aplicado: ${valorIva} -- Subtotal producto {i}: ${subtotal}\n");
            }

            Console.WriteLine($"El valor total de la venta de los 10 productos es: ${totalVenta}");

        }
    }
}
