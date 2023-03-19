using static ConsoleRPG.Utils.Generator;

namespace ConsoleRPG.Engine
{
    internal class Adventure
    {
        public int Width { get; }
        public int Height { get; }
        public char[,] Field { get; private set; }

        char Hero = '@';
        public char CurrentSymbol { get; set; }
        public int hero_x { get; private set; }
        public int hero_y { get; private set; }

        private void GenerateMap()
        {
            string char_set = "MAWC^^^^^^^#####****______,,,,,,,,,,,,.....:::++++++===``~~~                            ";
            for (int row = 0; row < Field.GetLength(0); row++)
            {
                for (int col = 0; col < Field.GetLength(1); col++)
                {
                    if (row == 0 || row == Height - 1 || col == 0 || col == Width - 1)
                        Field[row, col] = '#';
                    else
                        Field[row, col] = char_set[RandomNumber(0, char_set.Length-1)];
                }
            }
        }

        public void MoveHero(string direction)
        {
            bool CheckMove(int x, int y) => x > 0 && x < Width && y > 0 && y < Height && Field[y, x] != '#';

            Field[hero_y, hero_x] = CurrentSymbol;
            switch (direction)
            {
                case "Up": // Up
                    if (CheckMove(hero_x, hero_y - 1))
                        hero_y -= 1;
                    break;
                case "Down": // Down
                    if (CheckMove(hero_x, hero_y + 1))
                        hero_y += 1;
                    break;
                case "Right": // Right
                    if (CheckMove(hero_x + 1, hero_y))
                        hero_x += 1;
                    break;
                case "Left": // Left
                    if (CheckMove(hero_x - 1, hero_y))
                        hero_x -= 1;
                    break;
            }
            CurrentSymbol = Field[hero_y, hero_x];
            Field[hero_y, hero_x] = Hero;
        }

        public Adventure(int map_width, int map_height)
        {
            Width = map_width;
            Height = map_height;
            Field = new char[Height, Width];

            GenerateMap();

            hero_x = RandomNumber(0, Width - 1);
            hero_y = RandomNumber(0, Height - 1);
            CurrentSymbol = Field[hero_y, hero_x];
            Field[hero_y, hero_x] = Hero;
        }
    }
}
