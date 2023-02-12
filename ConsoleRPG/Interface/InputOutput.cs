using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Interface
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

        public enum AlignPrint
        {
            Right,
            Center,
            Left,
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
            for(int i = 0; i < menu.Length; i++)
            {
                PrintLine($"[{i+1}] {menu[i]}", align, color, background);
            }
        }
    }
}
