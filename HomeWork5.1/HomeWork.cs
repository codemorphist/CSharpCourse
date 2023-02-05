using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork5._1
{
    internal class HomeWork
    {
        private static int WindowWidth = 120;
        private static int WindowHeight = 30;

        private enum Align
        {
            CENTER,
            LEFT,
            RIGHT
        }

        static void PrintBaner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            PrintCenter("         _       _    _            _   _         _              _             _            _           _        ");
            PrintCenter("        / /\\    / /\\ /\\ \\         /\\_\\/\\_\\ _    /\\ \\           / /\\      _   /\\ \\         /\\ \\        /\\_\\      ");
            PrintCenter("       / / /   / / //  \\ \\       / / / / //\\_\\ /  \\ \\         / / /    / /\\ /  \\ \\       /  \\ \\      / / /  _   ");
            PrintCenter("      / /_/   / / // /\\ \\ \\     /\\ \\/ \\ \\/ / // /\\ \\ \\       / / /    / / // /\\ \\ \\     / /\\ \\ \\    / / /  /\\_\\ ");
            PrintCenter("     / /\\ \\__/ / // / /\\ \\ \\   /  \\____\\__/ // / /\\ \\_\\     / / /_   / / // / /\\ \\ \\   / / /\\ \\_\\  / / /__/ / / ");
            PrintCenter("    / /\\ \\___\\/ // / /  \\ \\_\\ / /\\/________// /_/_ \\/_/    / /_//_/\\/ / // / /  \\ \\_\\ / / /_/ / / / /\\_____/ /  ");
            PrintCenter("   / / /\\/___/ // / /   / / // / /\\/_// / // /____/\\      / _______/\\/ // / /   / / // / /__\\/ / / /\\_______/   ");
            PrintCenter("  / / /   / / // / /   / / // / /    / / // /\\____\\/     / /  \\____\\  // / /   / / // / /_____/ / / /\\ \\ \\      ");
            PrintCenter(" / / /   / / // / /___/ / // / /    / / // / /______    /_/ /\\ \\ /\\ \\// / /___/ / // / /\\ \\ \\  / / /  \\ \\ \\     ");
            PrintCenter("/ / /   / / // / /____\\/ / \\/_/    / / // / /_______\\   \\_\\//_/ /_/ // / /____\\/ // / /  \\ \\ \\/ / /    \\ \\ \\    ");
            PrintCenter("\\/_/    \\/_/ \\/_________/          \\/_/ \\/__________/       \\_\\/\\_\\/ \\/_________/ \\/_/    \\_\\/\\/_/      \\_\\_\\   ");
        }

        static string InputValue(string text)
        {
            /* This function receives a text parameter (what will be displayed in the console).
             * and returns the value entered by the user. */
            PrintCenter($"{text}: ");
            return Console.ReadLine();
        }

        static int InputInt(string text)
        {
            /* This function receives a text parameter (what will be displayed in the console).
             * and returns the int value entered by the user. */
            return Convert.ToInt32(InputValue(text));
        }


        static int MaxMenuLength(string[] menu)
        {
            int max_length = 0;
            foreach(string ithem in menu)
            {
                if (ithem.Length > max_length)
                    max_length = ithem.Length;
            }
            return max_length;
        }

        static void PrintMenu(string[] menu)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();

            int max_length = MaxMenuLength(menu);

            foreach (string ithem in menu)
            {
                Console.SetCursorPosition((WindowWidth -  max_length) / 2, Console.CursorTop);
                Console.WriteLine(ithem);
            }

            Console.ResetColor();
        }

        static void PrintCenter(string text)
        {
            Console.SetCursorPosition((WindowWidth - text.Length) / 2, Console.CursorTop + 1);
            Console.Write(text);
        }

        static void PrintRight(string text)
        {
            Console.SetCursorPosition(WindowWidth - text.Length, Console.CursorTop + 1);
            Console.Write(text);
        }

        static void Print(string text, 
            ConsoleColor color = ConsoleColor.Gray, 
            ConsoleColor background = ConsoleColor.Black,
            Align align = Align.LEFT)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;

            switch (align)
            {
                case Align.CENTER: 
                    PrintCenter(text); 
                    break;
                case Align.LEFT:
                    Console.WriteLine(text);
                    break;
                case Align.RIGHT:
                    PrintRight(text);
                    break;       
            }

            Console.ResetColor();
        }

        static void PrintFigure(char[,] figure)
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

        static void Print2DArray(int[,] array)
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


        static void ArrayClassTask()
        {

        }

        static void AsciiArtGeometry()
        {

        }

        static void Main(string[] args)
        {
            // Set window width and heigth
            Console.WindowWidth = WindowWidth;
            Console.WindowHeight = WindowHeight;

            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            // Menu initialization
            string[] Menu= { "[1] ", "[2] ASCII Фігури", "[0] Exit" };

            // Option for chose menu ithem
            int op;

            // Program Cycle
            do
            {
                Console.Clear();

                PrintBaner();

                Console.WriteLine();

                PrintMenu(Menu);

                op = InputInt("Введіть опцію із меню > ");

                switch (op)
                {
                    case 0: 
                        break;
                    case 1:
                        break;
                    case 2: 
                        break;
                    default:
                        Print("[ERROR] Такої опції не існує", ConsoleColor.DarkRed, align: Align.CENTER);
                        Print("Натисність будь яку клавішу щоб продовжити...", ConsoleColor.DarkGray, align: Align.CENTER);
                        Console.ReadLine();
                        break;
                }
            } while (op != 0);
        }
    }
}
