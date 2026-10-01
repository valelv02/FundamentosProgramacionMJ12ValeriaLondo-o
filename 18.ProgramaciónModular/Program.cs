using System;


namespace _18.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programación");
            MostrarMensaje("Valeria");
            MostrarMensaje("Valeria", "Londoño");
            Console.WriteLine($"Valeria tiene {CalcularEdad()} ");
            Console.WriteLine($"Valeria tiene {CalcularEdad(2008,2026)} ");
            Console.ReadKey();
            BorrarPantalla();
        }
        //Funciones con parámetros
        static int CalcularEdad(int añoActual, int AñoNacimiento)
        {
            return añoActual - AñoNacimiento;
        }

        //Funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        //Procedimientos sin parametros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimientos con parámetros

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenida, {nombre}  al curso de Fundamentos de Programación");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenida, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }


    }
}
