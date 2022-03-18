using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;

namespace Practice1Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Boolean ending = false;
            int opcion = 0;
            do
            {
                Console.WriteLine("\n\tCalculadora");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Sumar dos numeros.");
                Console.WriteLine("2. Restar dos numeros.");
                Console.WriteLine("3. Multiplicar dos numeros.");
                Console.WriteLine("4. Dividir dos numeros.");
                Console.WriteLine("5. Salir.");
                Console.Write("Opcion: ");
                
                
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("La suma de los numeros es: " + Addition(5,10));
                        break;
                    case 2:
                        Console.WriteLine("La resta de los numeros es: " + Substract(15,10));
                        break;
                    case 3:
                        Console.WriteLine("El producto de los numeros es: " + Multiplicar(5, 8));
                        break;
                    case 4:
                        Console.WriteLine("El cociente de los numeros es: " + Math.Round(Dividir(20,3), 4));
                        break;
                    case 5:
                        ending = true;
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada es incorrecta");
                        break;
                }
            } while (ending == false);
        }

        public static double Addition(int a, int b)
        {
            return a + b;
        }

        public static double Substract(int a, int b)
        {
            return a - b;
        }

        public static double Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static double Dividir(int a, int b)
        {
            double resultado = (double) a / (double) b;
            return resultado;
        }
        
    }
}