using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // This function return size of array
        public int GetSize() { return array.Length; }

        // This function return min value in array
        public int GetMin()
        {
            int min = array[0, 0];
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    min = (array[y, x] < min) ? array[y, x] : min;
                }
            }

            return min;
        }

        // This function return max value in array
        public int GetMax()
        {
            int max = array[0, 0];
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    max = (array[y, x] > max) ? array[y, x] : max;
                }
            }

            return max;
        }
        
        // This function return has value in array or not
        public bool Find(int value)
        {
            foreach (int x in array)
            {
                if (x == value) return true;
            }

            return false;
        }

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

        public void RotateRight()
        {
            // This function rotate array to left

            int x_size = array.GetLength(1);
            int y_size = array.GetLength(0);
            int[,] rotated_array = new int[x_size, y_size];

            for (int x = 0; x < x_size; x++)
                for (int y = 0; y < y_size; y++)
                    rotated_array[x, y] = array[y, x_size - x - 1];

            array = rotated_array;
        }

        public void RotateLeft()
        {
            // This function rotate array to right

            int x_size = array.GetLength(1);
            int y_size = array.GetLength(0);
            int[,] rotated_array = new int[x_size, y_size];

            for (int x = 0; x < x_size; x++)
                for (int y = 0; y < y_size; y++)
                    rotated_array[x, y] = array[y_size - y - 1, x];

            array = rotated_array;
        }

        public void Print2DArray()
        {
            // This function print 2d array

            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int x = 0; x < array.GetLength(0); x++)
                {
                    Console.Write($"{array[x, y]} ");
                }
                Console.WriteLine();
            }
        }
        public Array2D(int x_size, int y_size) 
        {
            array = new int[x_size, y_size];
        }
    }
}
