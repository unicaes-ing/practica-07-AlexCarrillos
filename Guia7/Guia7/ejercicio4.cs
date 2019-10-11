using System;
using System.Collections.Generic;
using System.Text;

namespace Guia7
{
    class ejercicio4
    {
        public static int[,] Nums;

        public static void CapturarDato()
        {
            Nums = new int[5, 5];
            Console.WriteLine("Ingrese los numeros de la matriz: ");
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    string numero;
                    numero = Console.ReadLine();
                    Nums[a, b] = int.Parse(numero);
                }
            }
        }

        public static void VerDatos()
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Console.WriteLine(Nums[a, b]);
                }
            }
        }

        static void Main(string[] args)
        {
            CapturarDato();
            VerDatos();
            Console.ReadKey();
        }
    }
}

