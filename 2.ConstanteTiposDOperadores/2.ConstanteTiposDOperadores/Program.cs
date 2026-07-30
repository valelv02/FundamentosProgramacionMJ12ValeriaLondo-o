using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "Valeria";
            nombre = "Vale";
            //gravedad = "10"; No puedo cambiar el valor de una constante 

            //TIPOS DE DATOS 
            byte dato1 = 0;//de 0 a 255
            int dato2 = -256;//entero con signo
            ulong dato3 = 546543216545;//enteros positivos más grandes
            float dato4 = 2.2f;// poner f siempre al final
            double dato5 = 320948320948.2920939d;//decimal grande, no requiere sufijo pero puede tener la d 
            decimal dato6 = 93239840938.89340509609760960967m;//sufijo m para el decimal


            char dato7 = 'K';//almacena un solo caracter. se usa con comillas simples ''
            string dato8 = "Hola si no 981233_}}_*¡";// frases, numeros, simbolos, cualquier caracter
            bool dato9 = false; //true or false
            object dato10 = new object(); //raíz de todas las clases


            //OPERADORES
            //Operadores numéricos
            //Cambio de signo
            int dato11 = 2;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}, dato13:{2}, dato14:{3}", dato11, dato12, dato13, dato14);

            //Operadores aritméticos
            int dato15 = 2 + 6;//Suma
            int dato16 = dato15 - 2;//Resta
            int dato17 = 2 * 12;//Producto
            float dato18 =(float) 67 / 69;//División
            Console.WriteLine("Suma:{0}, Resta:{1}, Producto:{2}, División:{3}", dato15, dato16, dato17, dato18);
        }
    }
}
