using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1
{
    internal class Array2D
    {
        private Random random = new Random();
        private int[,] array;

        // This function return array
        public int[,] GetArray() { return array; }

        public void RandomArray(int min = 10, int max = 99)
        {
            /* This function receives min/max (minimum/maximum random value) and fill array
             * with random values from min to max */
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = random.Next(min, max + 1);
                }
            }
        }

        public void RotateLeft()
        {
            // This function rotate array to left
            if (array.GetLength(0) != array.GetLength(1)) { return; }

            int size = array.GetLength(0);
            int[,] rotated_array = new int[size, size];

            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    rotated_array[x, y] = array[y, size - x - 1];

            array = rotated_array;
        }

        public void RotateRight()
        {
            // This function rotate array to right
            if (array.GetLength(0) != array.GetLength(1)) { return; }

            int size = array.GetLength(0);
            int[,] rotated_array = new int[size, size];

            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    rotated_array[x, y] = array[size - y - 1, x];

            array = rotated_array;
        }

        public Array2D(int x_size, int y_size) 
        {
            array = new int[x_size, y_size];
        }
    }
}
