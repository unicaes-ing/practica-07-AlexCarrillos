using System;
using System.Collections.Generic;
using System.Text;

namespace Guia7
{
    class ejercicio3
    {
        public static string[][] datos;

        public static void Datos()
        {
            int equipos, jugadores;
            Console.WriteLine("Escriba la cantidad de equipos: ");
            equipos = int.Parse(Console.ReadLine());
            datos = new string[equipos][];
            for (int a = 0; a < datos.Length; a++)
            {
                Console.WriteLine("Escriba la cantidad de jugadores del equipo #{0}", a + 1);
                jugadores = int.Parse(Console.ReadLine());
                datos[a] = new string[jugadores];
                for (int b = 0; b < datos[a].Length; b++)
                {
                    Console.WriteLine("Escriba el nombre del jugador #{0}: ", b + 1);
                    datos[a][b] = Console.ReadLine();
                }
            }
        }

        public static void Mostrar()
        {
            Console.WriteLine("Informacion de los equipos: ");
            for (int a = 0; a < datos.Length; a++)
            {
                Console.WriteLine("Equipo #{0}", a + 1);
                for (int b = 0; b < datos[a].Length; b++)
                {
                    Console.WriteLine(datos[a][b]);
                }
            }
        }

        static void Main(string[] args)
        {
            Datos();
            Mostrar();
            Console.ReadKey();
        }
    }
    
}
