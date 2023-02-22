using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using ConsoleRPG.Items;
using Microsoft.SqlServer.Server;
using static ConsoleRPG.Utils.Dictionaries;

namespace ConsoleRPG.Utils
{
    static class Generator
    {
        private static readonly Random random = new Random();

        public static int RandomNumber(int min, int max) => random.Next(min, max + 1);

        public static string GenerateName()
        {
            /* This function return random name for Monster */
            return GenerataFirstPart() + " " + GenerateSecondPart();
        }

        private static string GenerataFirstPart()
        {
            /* This function return first part of random name */
            if (random.NextDouble() > 0.5)
            {
                int nameIndex = random.Next(nm1.Length);
                return nm1[nameIndex];
            }

            int nameIndex1 = random.Next(nm3.Length);
            int nameIndex2 = random.Next(nm4.Length);
            return nm3[nameIndex1] + nm4[nameIndex2];
        }

        private static string GenerateSecondPart()
        {
            /* This function return second part of random name */
            if (random.NextDouble() > 0.5)
            {
                int nameIndex = random.Next(nm2.Length);
                return nm2[nameIndex];
            }

            int nameIndex1 = random.Next(nm5.Length);
            int nameIndex2 = random.Next(nm6.Length);
            return nm5[nameIndex1] + nm6[nameIndex2];
        }

        public static string GenerateItemName(IthemType type, IthemRank rank)
        {
            /* This function return random name of Item by type */
            switch (type)
            {
                case IthemType.Helmet:
                    return GenerateHelmetName(rank);
                case IthemType.Chest:
                    return GenerateChestName(rank);
                case IthemType.Leggins:
                    return GenerateLegginsName(rank);
                case IthemType.Boots: 
                    return GenerateBootsName(rank);
                default:
                    return "";
            }
        }

        public static string GenerateWeaponName()
        {
            /* This function return random Weapon name */
            return "";
        }

        public static string GenerateHelmetName(IthemRank rank)
        {
            /* This function return random Helmet name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return Generator1(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight);
                case 2:
                    return Generator2(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return Generator3(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return Generator4(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight);
                case 5:
                    return Generator5();
            }

            return "";
        }

        public static string GenerateChestName(IthemRank rank)
        {
            /* This function return random Armor name */
            int generator_type = random.Next(1,6);

            switch(generator_type)
            {
                case 1:
                    return Generator1(rank == IthemRank.Heavy ? ChestHeavy : ChestLight);
                case 2:
                    return Generator2(rank == IthemRank.Heavy ? ChestHeavy : ChestLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return Generator3(rank == IthemRank.Heavy ? ChestHeavy : ChestLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return Generator4(rank == IthemRank.Heavy ? ChestHeavy : ChestLight);
                case 5:
                    return Generator5();
            }

            return "";
        }

        public static string GenerateLegginsName(IthemRank rank)
        {
            /* This function return random Leggins name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return Generator1(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight);
                case 2:
                    return Generator2(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return Generator3(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return Generator4(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight);
                case 5:
                    return Generator5();
            }

            return "";
        }

        public static string GenerateBootsName(IthemRank rank)
        {
            /* This function return random Boots name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return Generator1(rank == IthemRank.Heavy ? BootsHeavy : BootsLight);
                case 2:
                    return Generator2(rank == IthemRank.Heavy ? BootsHeavy : BootsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return Generator3(rank == IthemRank.Heavy ? BootsHeavy : BootsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return Generator4(rank == IthemRank.Heavy ? BootsHeavy : BootsLight);
            }

            return "";
        }

        private static string RandomElem(string[] array)
        {
            return array[random.Next(0, array.Length)];
        }

        // Generate like 'Chest of Adjective Noun'
        private static string Generator1(string[] Ithem)
        {
            return $"{RandomElem(Ithem)} of {RandomElem(Adjective1)} {RandomElem(Noun)}";
        }

        // Generate like 'Material Chest of Adjective Noun'
        private static string Generator2(string[] Ithem, string[] Material)
        {
            return $"{RandomElem(Material)} {RandomElem(Ithem)} of {RandomElem(Adjective1)} {RandomElem(Adjective2)}";
        }

        // Generate like '(Adjective) Material Chest'
        private static string Generator3(string[] Ithem, string[] Material)
        {
            return $"{RandomElem(Adjective3)} {RandomElem(Material)} {RandomElem(Ithem)}";
        }

        // Generate like '(Adjective) Ithem of (the) Noun'
        private static string Generator4(string[] Ithem)
        {
            return $"{RandomElem(Adjective3)} of {RandomElem(Ithem)} {RandomElem(Noun)}";
        }

        // Generate like 'Adjective/Verb/Preposition of (the) Noun'
        private static string Generator5()
        {
            return $"{RandomElem(AdjectiveVerbPreposition)} of {RandomElem(Noun)}";
        }
    }
}
