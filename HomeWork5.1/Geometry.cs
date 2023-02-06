using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1
{
    internal class Geometry
    {
        private char[,] figure;
        private char symbol;
        private char space;

        // This function return array with figure
        public char[,] GetFigure() { return figure; }

        public void Triangle(int height)
        {
            // This function draw triangle

            int size = 2 * height - 1;
            figure = new char[size, size];

            int center = size / 2;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                    figure[x, y] = (x <= center + y / 2 && x >= center - y / 2 && y % 2 == 0) ? symbol : space;
            }
        }

        public void ReverseTriangle(int height)
        { 
            // This function draw reversed triangle

            int size = 2 * height - 1;
            figure = new char[size, size];

            int center = size / 2;
            for (int y = size; y > 0; y--)
            {
                for (int x = 0; x < size; x++)
                    figure[x, size - y] = (x <= center + y / 2 && x >= center - y / 2 && y % 2 != 0) ? symbol : space;
            }
        }

        public void Diamond(int height)
        {
            // This function draw diamond

            int width = 2 * height - 1;
            height = 2 * width - 1;

            figure = new char[width, height];

            int center = (width - 1) / 2;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y <= (height - 1) / 2)
                        figure[x, y] = (x <= center + y / 2 && x >= center - y / 2 && y % 2 == 0) ? symbol : space;
                    else
                        figure[x, y] = (x <= center + (height - y - 1) / 2 && x >= center - (height - y - 1) / 2 && y % 2 == 0) ? '*' : ' ';
                }
            }
        }

        public void DrawFigure()
        {
            // This function draw figure from 2d array

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

        public Geometry(char symbol = '*', char space = ' ') 
        {
            this.symbol = symbol;
            this.space = space;
        }
    }
}
