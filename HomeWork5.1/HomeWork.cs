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

        static void Main(string[] args)
        {
            Geometry Figure = new Geometry();

            char[,] figure = Figure.Diamond(5);

            PrintFigure(figure);
        }
    }
}
