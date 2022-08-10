using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];

            for(int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for(int colum =0; colum < matriz.GetLength(1); colum++)
                {
                    matriz[filas, colum] = (filas + 1) * (colum + 1);

                }

            }
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (int colum = 0; colum < matriz.GetLength(1); colum++)
                {
                    Console.WriteLine(matriz[filas, colum]);

                }

            }
        }
    }
}
