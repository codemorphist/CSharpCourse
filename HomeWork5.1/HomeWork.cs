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
        // Windows parameters
        private static int WindowWidth = 120;
        private static int WindowHeight = 30;

        // Enum for print function
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

        private static bool InputYesNo(string text)
        {
            /* This function receives a text parameter (what will be displayed in the console).
             * and returns the bool value entered by the user (Yes or No). */
            string choice;
            choice = InputValue(text + " (Так або Ні)").ToLower();

            if (choice == "так" || choice == "yes" || choice == "y" || choice == "1")
                return true;
            else
                return false;
        }

        static int MaxMenuLength(string[] menu)
        {
            // This function return max length string from string array 

            int max_length = 0;
            foreach(string ithem in menu)
            {
                if (ithem.Length > max_length)
                    max_length = ithem.Length;
            }
            return max_length;
        }

        static void PrintMenu(string[] menu, ConsoleColor color = ConsoleColor.Red)
        {
            // This function print menu form string array

            Console.ForegroundColor = color;

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
            // This function print text on center of Console

            Console.SetCursorPosition((WindowWidth - text.Length) / 2, Console.CursorTop + 1);
            Console.Write(text);
        }

        static void PrintRight(string text)
        {
            // This function print text on right of Console

            Console.SetCursorPosition(WindowWidth - text.Length, Console.CursorTop + 1);
            Console.Write(text);
        }

        static void Print(string text, 
            ConsoleColor color = ConsoleColor.Gray, 
            ConsoleColor background = ConsoleColor.Black,
            Align align = Align.LEFT)
        {
            /* This function print text with given foreground and background colors 
             * and alignt text by left, center or right. */

            // Set foreground and background colors
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;

            // Align text
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

            // Reset Console color settings
            Console.ResetColor();
        }

        // Option 1: Array Task
        static void ArrayClassTask()
        {
            Console.Clear();

            int width = InputInt("Введіть ширину масиву");
            int height = InputInt("Введіть висоту масиву");

            Array2D array = new Array2D(width, height);

            Console.Clear();

            Print("Масив: ");
            array.Print2DArray();

            Print("\nМасив заповнений ввипадковими числами: ");
            array.RandomArray();
            array.Print2DArray();

            Print("\nПовернутий вліво: ");
            array.RotateLeft();
            array.Print2DArray();

            Print($"\nРозмір масиву: {array.GetSize()}");
            Print($"Максимальний елемент: {array.GetMax()}");
            Print($"Мінімальний елемент: {array.GetMin()}");
            Print($"Чи є в масиві число 44: {array.Find(4)}");
        }

        // Option 2: Geometry Task
        static void AsciiArtGeometry()
        {
            Console.Clear();
            
            Geometry figure = new Geometry();

            string[] menu = { "Виберіть що будемо малювати:", "[1] Трикутник", "[2] Перевернутий трикутник", "[3] Ромб" };

            PrintMenu(menu, ConsoleColor.Blue);
            int op = InputInt("Ведіть пункт з меню");
            int height = InputInt("Введіть висоту фігури");

            switch(op)
            {
                case 1: 
                    figure.Triangle(height);
                    break;
                case 2: 
                    figure.ReverseTriangle(height);
                    break;
                case 3: 
                    figure.Diamond(height);
                    break;
            }

            Console.Clear();

            figure.DrawFigure();
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
            string[] Menu= { "[1] Двовимірний масив", "[2] ASCII Фігури", "[0] Exit" };

            // Option for chose menu ithem
            int op;
            bool cont = false;

            // Program Cycle
            do
            {
                Console.Clear();

                PrintBaner();

                Console.WriteLine();

                PrintMenu(Menu);

                op = InputInt("Введіть опцію із меню");

                // Run some function from option
                do
                {
                    switch (op)
                    {
                        case 0:
                            break;
                        case 1:
                            ArrayClassTask();
                            cont = InputYesNo("Бажаєте порахувати ще раз?");
                            break;
                        case 2:
                            AsciiArtGeometry();
                            cont = InputYesNo("Бажаєте порахувати ще раз?");
                            break;
                        default:
                            Print("[ERROR] Такої опції не існує", ConsoleColor.DarkRed, align: Align.CENTER);
                            Print("Натисність будь яку клавішу щоб продовжити...", ConsoleColor.DarkGray, align: Align.CENTER);
                            cont = false;
                            Console.ReadLine();
                            break;
                    } 
                } while (cont);
            } while (op != 0);
        }
    }
}
