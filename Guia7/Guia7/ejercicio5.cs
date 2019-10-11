using System;
using System.Collections.Generic;
using System.Text;

namespace Guia7
{
    class ejercicio5
    {
        public static int[,] Nums1;

        public static int[,] Nums2;

        static int Suma(int[,] datos)
        {
            int suma = 0;
            for (int a = 0; a < datos.GetLength(0); a++)
            {
                for (int b = 0; b < datos.GetLength(1); b++)
                {
                    suma = datos[a, b];
                }
            }
            return suma;
        }

        static int suma2(int[,] datos)
        {
            int suma = 0;
            for (int a = 0; a < datos.GetLength(0); a++)
            {
                for (int b = 0; b < datos.GetLength(1); b++)
                {
                    suma = datos[a, b];
                }
            }
            return suma;
        }

        static void Main(string[] args)
        {
            int total = 0;
            Nums1 = new int[3, 3];
            Console.WriteLine("Ingrese los numeros de la primera matriz: ");
            for (int a = 0; a < Nums1.GetLength(0); a++)
            {
                for (int b = 0; b < Nums1.GetLength(1); b++)
                {
                    string num;
                    num = Console.ReadLine();
                    Nums1[a, b] = int.Parse(num);
                }
            }
            Console.Clear();
            Nums2 = new int[3, 3];
            Console.WriteLine("Ingrese los numeros de la segunda matriz: ");
            for (int a = 0; a < Nums2.GetLength(0); a++)
            {
                for (int b = 0; b < Nums2.GetLength(1); b++)
                {
                    string num;
                    num = Console.ReadLine();
                    Nums2[a, b] = int.Parse(num);
                }
            }
            Console.Clear();
            total = Suma(Nums1) + suma2(Nums2);
            Console.WriteLine("Suma de matrices: {0:N0}", total);
            Console.ReadKey();
        }
    }
}

