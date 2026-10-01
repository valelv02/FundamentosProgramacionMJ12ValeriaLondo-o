using System;


namespace Parcial_1_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int opcionSala = 0;
            int opcionJuego = 0;
            string sala = "";
            string juego = "";
            int precio = 0;

            // a
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            // b
            if (edad >= 1 && edad <= 5)
            {
                sala = "Sala 1";
            }
            else if (edad >= 6 && edad <= 16)
            {
                sala = "Sala 2";
            }
            else if (edad >= 17 && edad <= 25)
            {
                Console.WriteLine("Salas habilitadas para su edad:");
                Console.WriteLine("3. Sala 3");
                Console.WriteLine("4. Sala 4");
                Console.WriteLine("Seleccione una sala (3 o 4):");
                opcionSala = int.Parse(Console.ReadLine());

                if (opcionSala == 3)
                {
                    sala = "Sala 3";
                }
                else if (opcionSala == 4)
                {
                    sala = "Sala 4";
                }
                else
                {
                    Console.WriteLine("Selección de sala no válida.");
                    return;
                }
            }
            else if (edad >= 26)
            {
                sala = "Sala 5";
            }
            else
            {
                Console.WriteLine("Error: La edad ingresada no es válida.");
                return;
            }

            // c
            switch (sala)
            {
                case "Sala 1":
                    Console.WriteLine("Juegos disponibles: 1. Juego1 | 5. Juego5");
                    break;
                case "Sala 2":
                    Console.WriteLine("Juegos disponibles: 3. Juego3 | 6. Juego6");
                    break;
                case "Sala 3":
                    Console.WriteLine("Juegos disponibles: 2. Juego2 | 7. Juego7");
                    break;
                case "Sala 4":
                    Console.WriteLine("Juegos disponibles: 4. Juego4 | 8. Juego8");
                    break;
                case "Sala 5":
                    Console.WriteLine("Juegos disponibles: 9. Juego9 | 10. Juego10");
                    break;
                default:
                    Console.WriteLine("Elija una opción válida");
                    break;
            }

            Console.WriteLine("Ingrese el número del juego que quiere elegir:");
            opcionJuego = int.Parse(Console.ReadLine());

            if (sala == "Sala 1" && (opcionJuego == 1 || opcionJuego == 5))
            {
                juego = "Juego" + opcionJuego;
            }
            else if (sala == "Sala 2" && (opcionJuego == 3 || opcionJuego == 6))
            {
                juego = "Juego" + opcionJuego;
            }
            else if (sala == "Sala 3" && (opcionJuego == 2 || opcionJuego == 7))
            {
                juego = "Juego" + opcionJuego;
            }
            else if (sala == "Sala 4" && (opcionJuego == 4 || opcionJuego == 8))
            {
                juego = "Juego" + opcionJuego;
            }
            else if (sala == "Sala 5" && (opcionJuego == 9 || opcionJuego == 10))
            {
                juego = "Juego" + opcionJuego;
            }
            else
            {
                Console.WriteLine("La selección de juego no es válida.");
                return;
            }

            // d
            switch (juego)
            {
                case "Juego1":
                    precio = 3000;
                    break;
                case "Juego2":
                    precio = 5000;
                    break;
                case "Juego3":
                    precio = 7000;
                    break;
                case "Juego4":
                    precio = 9000;
                    break;
                case "Juego5":
                    precio = 7000;
                    break;
                case "Juego6":
                    precio = 9000;
                    break;
                case "Juego7":
                    precio = 10000;
                    break;
                case "Juego8":
                    precio = 7000;
                    break;
                case "Juego9":
                    precio = 5000;
                    break;
                case "Juego10":
                    precio = 3000;
                    break;
                default:
                    Console.WriteLine("Elija una opción válida");
                    break;
            }

            // e 
            Console.WriteLine("Información");
            Console.WriteLine("Edad del usuario: " + edad);
            Console.WriteLine("Sala seleccionada: " + sala);
            Console.WriteLine("Juego seleccionado: " + juego);
            Console.WriteLine("Precio a pagar: $" + precio);
        }
    }
}
