using System;
using System.Collections.Generic;
using System.Text;

namespace Guia7
{
    class ejercicio2
    {
         static void Main(string[] args)
        {
            int num, n;
            int pares = 0, impares = 0;
            Console.WriteLine("Ingrese la cantidad de numeros: ");
            num = int.Parse(Console.ReadLine());
            int[] Nums = new int[num];
            for (int i = 0; i < Nums.Length; i++)
            {
                Console.WriteLine("Ingrese el numero #{0}: ", i+1);
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.Clear();
            Console.WriteLine("Numero pares: {0}", pares);
            Console.WriteLine("Numero impares: {0}", impares);
            Console.ReadKey();
         }
    }
    
}
