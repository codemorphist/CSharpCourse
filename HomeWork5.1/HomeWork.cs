using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1
{
    internal class HomeWork
    {
        private static void PrintFigure(char[,] figure)
        {
            // This function print figure from 2d array
            Console.WriteLine();
            for (int y = 0; y < figure.GetLength(1); y++)
            {
                for (int x = 0; x < figure.GetLength(0); x++)
                {
                    Console.Write(figure[x, y]);
                }
                Console.WriteLine();
            }
        }

        private static void Print2DArray(int[,] array)
        {
            // This function print figure from 2d array
            Console.WriteLine();
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int x = 0; x < array.GetLength(0); x++)
                {
                    Console.Write($"{array[x, y]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Array2D array = new Array2D(4, 6);

            array.RandomArray();

            Print2DArray(array.GetArray());

            Console.WriteLine();

            array.RotateLeft();

            Print2DArray(array.GetArray());
        }
    }
}
