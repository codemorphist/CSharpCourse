using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        private static string InputValue(string text)
        {
            // This function return inputed by user value
            Console.Write(text);    
            return Console.ReadLine();
        }

        private static int InputInt(string text)
        {
            // This function return inputed by user integer
            return Convert.ToInt32(InputValue(text));
        }

        private static Player CreatePlayer()
        {
            // Name of player input
            string name = InputValue("Введіть ім'я персонажа: ");
            
            // Type of Player input
            Console.Write("\n[1] Варвар\n" +
                          "[2] Танк\n" +
                          "[3] Розбійник\n");
            string type = "";
            switch(InputInt("Виберіть тип персонажа: "))
            {
                case 1:
                    type = "Barbarian";
                    break;
                case 2:
                    type = "Tank";
                    break;
                case 3:
                    type = "Bandit";
                    break;
            }

            // Create new Player
            Player player = new Player(name, type);

            Console.WriteLine($"\nВи створили персонажа з іменем: {name}, та типом: {type}.");
            return player;
        }

        static void Main(string[] args)
        {
            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Player player = CreatePlayer();

            Console.WriteLine(player.Health);

            player.Health -= 5;

            Console.WriteLine(player.Health);
        }
    }
}
