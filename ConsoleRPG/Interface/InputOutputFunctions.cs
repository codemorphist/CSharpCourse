using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Interface
{
    internal class InputOutputFunctions
    {
        public string InputValue()
        {
            return Console.ReadLine();
        }

        public int InputInt()
        {
            return Convert.ToInt32(InputValue());
        }

        public char InputChar()
        {
            return Convert.ToChar(InputValue());
        }

        private void PrintCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.Write(text);
        }

        private void PrintRight(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth - text.Length, Console.CursorTop);
            Console.Write(text);
        }

        private void PrintLeft(string text)
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

        public void Print(string text, AlignPrint align = AlignPrint.None, 
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

        public void PrintByCords(string text, int left, int top,
                                 ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            left = (left > Console.WindowWidth) ? Console.WindowWidth - text.Length : left;
            top = (top > Console.WindowHeight) ? Console.WindowHeight - 1 : top;

            Console.SetCursorPosition(left, top);
            Print(text, AlignPrint.None, color, background);
        }
    }
}
