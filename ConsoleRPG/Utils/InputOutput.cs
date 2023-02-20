using System;
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

        public static char InputChar()
        {
            return Convert.ToChar(InputValue());
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

        public static int MaxLenInStringArray(string[] array)
        {
            int max = 0;

            foreach (string elem in array)
            {
                if (elem.Length > max)
                    max = elem.Length;
            }

            return max;
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


        public static void Print(string text, AlignPrint align = AlignPrint.None, 
                          ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
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

        public static void PrintLine(string text, AlignPrint align = AlignPrint.None,
                          ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            Print(text, align, color, background);
            Console.CursorTop += 1;
        }

        public static void PrintByCords(string text, int left, int top,
                                 ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            left = (left > Console.WindowWidth) ? Console.WindowWidth - text.Length : left;
            top = (top > Console.WindowHeight) ? Console.WindowHeight - 1 : top;

            Console.SetCursorPosition(left, top);
            Print(text, AlignPrint.None, color, background);
        }

        public static void PrintMenu(string[] menu, AlignPrint align = AlignPrint.None,
                          ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            int left = (Console.WindowWidth - MaxLenInStringArray(menu)) / 2;

            foreach (string elem in menu)
            {
                Console.SetCursorPosition(left, Console.CursorTop);
                Print(elem, AlignPrint.None, color, background);
                Console.CursorTop += 1;
            }
        }

        public static void PrintArray(string[] array, AlignPrint x_align = AlignPrint.None, AlignPrint y_align = AlignPrint.None,
                                    ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            switch(y_align)
            {
                case AlignPrint.Top:
                    Console.SetCursorPosition(Console.CursorLeft, 0);
                    break;
                case AlignPrint.Center:
                    Console.SetCursorPosition(Console.CursorLeft, (Console.WindowHeight - array.Length) / 2);
                    break;
                case AlignPrint.Bottom:
                    Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight);
                    break;
            }

            for (int i = 0; i < array.Length; i++)
            {

                PrintLine(array[i], x_align, color, background);
            }
        }

        public static void PrintArrayByCords(string[] array, int left, int top,
                          ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PrintByCords(array[i], left, top + i, color, background);
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
