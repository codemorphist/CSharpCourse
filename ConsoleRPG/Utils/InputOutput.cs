using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Threading;

namespace ConsoleRPG.Utils
{
    public static class InputOutput
    {
        public static string InputValue()
        {
            return Console.ReadLine();
        }

        public static int InputInt()
        {
            return Convert.ToInt32(InputValue());
        }

        public static double InputDouble() 
        {
            return Convert.ToDouble(InputValue());
        }

        public static char InputChar()
        {
            return Convert.ToChar(InputValue());
        }

        
        public static int MaxLenInStringArray(string[] array)
        {
            int max_len = array[0].Length;

            foreach (string elem in array) 
            {
                if (elem.Length > max_len)
                    max_len = elem.Length;
            }

            return max_len;
        }

        private static void PrintCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.Write(text);
        }

        private static void PrintRight(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth - text.Length, Console.CursorTop);
            Console.Write(text);
        }

        private static void PrintLeft(string text)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(text);
        }

        public enum AlignPrint
        {
            Right,
            Center,
            Left,
            Top,
            Bottom,
            None
        }

        public static void Print(int value,
                                 AlignPrint align = AlignPrint.None,
                                 ConsoleColor color = ConsoleColor.White,
                                 ConsoleColor background = ConsoleColor.Black)
        {
            Print(value.ToString(), align, color, background);
        }

        public static void Print(double value,
                                 AlignPrint align = AlignPrint.None,
                                 ConsoleColor color = ConsoleColor.White,
                                 ConsoleColor background = ConsoleColor.Black)
        {
            Print(value.ToString(), align, color, background);
        }

        public static void Print(bool value,
                                 AlignPrint align = AlignPrint.None,
                                 ConsoleColor color = ConsoleColor.White,
                                 ConsoleColor background = ConsoleColor.Black)
        {
            Print(value.ToString(), align, color, background);
        }

        public static void Print(char value,
                                 AlignPrint align = AlignPrint.None,
                                 ConsoleColor color = ConsoleColor.White,
                                 ConsoleColor background = ConsoleColor.Black)
        {
            Print(value.ToString(), align, color, background);
        }

        public static void Print(string text, 
                                 AlignPrint align = AlignPrint.None, 
                                 ConsoleColor color = ConsoleColor.White, 
                                 ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;

            switch(align)
            {
                case AlignPrint.Left:
                    PrintLeft(text);
                    break;
                case AlignPrint.Right:
                    PrintRight(text);
                    break;
                case AlignPrint.Center:
                    PrintCenter(text);
                    break;
                default:
                    Console.Write(text);
                    break;
            }

            Console.ResetColor();
        }

        public static void PrintByCords(string text, int x, int y,
                                        ConsoleColor color = ConsoleColor.White, 
                                        ConsoleColor background = ConsoleColor.Black)
        {
            if (x > Console.WindowWidth || x < 0 || y > Console.WindowHeight || y < 0)
                return;

            Console.SetCursorPosition(x, y);
            Print(text, color: color, background: background);
        }

        public static void PrintArt(string[] array, int x, int y)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Print(array[i]);
            }
        }

        public static void PrintArray(string[] array)
        {
            int x = Console.CursorLeft;
            foreach (string elem in array)
            {
                Print(elem);
                Console.CursorTop++;
                Console.CursorLeft = x;
            }
        }

        public static void PrintArrayByCords(string[] array, int x, int y)
        {
            foreach (string elem in array)
            {
                PrintByCords(elem, x, y);
                y += 1;
            }
        }

        public static void AnimatedPrint(string text, int delay = 40)
        {
            foreach (char symb in text)
            {
                Console.Write(symb);
                Thread.Sleep(delay);
            }
        }
    }
}
