using System;

using ConsoleRPG.Items;
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

        public static string GenerateArmorName(IthemType type, IthemRank rank)
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

        public static string GenerateWeaponName(IthemType type)
        {
            /* This function return random Weapon name */
            switch (type)
            {
                case IthemType.Sword:
                    return GenerateSwordName();
                case IthemType.Hummer:
                    return GenerateHummerName();
                case IthemType.Axe:
                    return GenerateAxeName();
                case IthemType.Spear:
                    return GenerateSpearName();
                default:
                    return "";
            }
        }

        private static string GenerateHelmetName(IthemRank rank)
        {
            /* This function return random Helmet name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return ArmorGenerator1(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight);
                case 2:
                    return ArmorGenerator2(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return ArmorGenerator3(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return ArmorGenerator4(rank == IthemRank.Heavy ? HelmetHeavy : HelmetLight);
                case 5:
                    return ArmorGenerator5();
                default:
                    return "";
            }
        }

        private static string GenerateChestName(IthemRank rank)
        {
            /* This function return random Armor name */
            int generator_type = random.Next(1,6);

            switch(generator_type)
            {
                case 1:
                    return ArmorGenerator1(rank == IthemRank.Heavy ? ChestHeavy : ChestLight);
                case 2:
                    return ArmorGenerator2(rank == IthemRank.Heavy ? ChestHeavy : ChestLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return ArmorGenerator3(rank == IthemRank.Heavy ? ChestHeavy : ChestLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return ArmorGenerator4(rank == IthemRank.Heavy ? ChestHeavy : ChestLight);
                case 5:
                    return ArmorGenerator5();
                default:
                    return "";
            }
        }

        private static string GenerateLegginsName(IthemRank rank)
        {
            /* This function return random Leggins name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return ArmorGenerator1(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight);
                case 2:
                    return ArmorGenerator2(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return ArmorGenerator3(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return ArmorGenerator4(rank == IthemRank.Heavy ? LegginsHeavy : LegginsLight);
                case 5:
                    return ArmorGenerator5();
                default:
                    return "";
            }
        }

        private static string GenerateBootsName(IthemRank rank)
        {
            /* This function return random Boots name */
            int generator_type = random.Next(1, 6);

            switch (generator_type)
            {
                case 1:
                    return ArmorGenerator1(rank == IthemRank.Heavy ? BootsHeavy : BootsLight);
                case 2:
                    return ArmorGenerator2(rank == IthemRank.Heavy ? BootsHeavy : BootsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 3:
                    return ArmorGenerator3(rank == IthemRank.Heavy ? BootsHeavy : BootsLight, rank == IthemRank.Heavy ? MaterialHeavy : MaterialLight);
                case 4:
                    return ArmorGenerator4(rank == IthemRank.Heavy ? BootsHeavy : BootsLight);
                default:
                    return "";
            }
        }

        private static string GenerateSwordName()
        {
            /* This function return random Sword name */
            int generator_type = random.Next(1, 5);

            switch (generator_type)
            {
                case 1:
                    return WeaponGenerator1();
                case 2:
                    return WeaponGenerator2(SwordNames);
                case 3:
                    return WeaponGenerator3(SwordNames);
                case 4:
                    return WeaponGenerator4(SwordNames);
                default:
                    return "";
            }
        }

        private static string GenerateHummerName()
        {
            /* This function return random Hummer name */
            int generator_type = random.Next(1, 5);

            switch (generator_type)
            {
                case 1:
                    return WeaponGenerator1();
                case 2:
                    return WeaponGenerator2(HummerNames);
                case 3:
                    return WeaponGenerator3(HummerNames);
                case 4:
                    return WeaponGenerator4(HummerNames);
                default:
                    return "";
            }
        }

        private static string GenerateAxeName() 
        {
            /* This function return random Axe name */
            int generator_type = random.Next(1, 5);

            switch (generator_type)
            {
                case 1:
                    return WeaponGenerator1();
                case 2:
                    return WeaponGenerator2(AxeNames);
                case 3:
                    return WeaponGenerator3(AxeNames);
                case 4:
                    return WeaponGenerator4(AxeNames);
                default:
                    return "";
            }
        }

        private static string GenerateSpearName()
        {
            /* This function return random Spear name */
            int generator_type = random.Next(1, 5);

            switch (generator_type)
            {
                case 1:
                    return WeaponGenerator1();
                case 2:
                    return WeaponGenerator2(SpearNames);
                case 3:
                    return WeaponGenerator3(SpearNames);
                case 4:
                    return WeaponGenerator4(SpearNames);
                default:
                    return "";
            }
        }

        private static string RandomElem(string[] array)
        {
            return array[random.Next(0, array.Length)];
        }

        // Generate like 'Chest of Adjective Noun'
        private static string ArmorGenerator1(string[] Ithem)
        {
            return $"{RandomElem(Ithem)} of {RandomElem(Adjective1)} {RandomElem(Noun)}";
        }

        // Generate like 'Material Chest of Adjective Noun'
        private static string ArmorGenerator2(string[] Ithem, string[] Material)
        {
            return $"{RandomElem(Material)} {RandomElem(Ithem)} of {RandomElem(Adjective1)} {RandomElem(Adjective2)}";
        }

        // Generate like '(Adjective) Material Chest'
        private static string ArmorGenerator3(string[] Ithem, string[] Material)
        {
            return $"{RandomElem(Adjective3)} {RandomElem(Material)} {RandomElem(Ithem)}";
        }

        // Generate like '(Adjective) Ithem of (the) Noun'
        private static string ArmorGenerator4(string[] Ithem)
        {
            return $"{RandomElem(Adjective3)} of {RandomElem(Ithem)} {RandomElem(Noun)}";
        }

        // Generate like 'Adjective/Verb/Preposition of (the) Noun'
        private static string ArmorGenerator5()
        {
            return $"{RandomElem(AdjectiveVerbPreposition)} of {RandomElem(Noun)}";
        }

        // Generate like 'Weapon'
        private static string WeaponGenerator1()
        {
            return RandomElem(WeaponName);
        }

        // Generate like 'Adjective Weapon'
        private static string WeaponGenerator2(string[] WeaponSpecName) 
        {
            return $"{RandomElem(Adjective4)} {RandomElem(WeaponSpecName)}";
        }

        // Generate like 'Adjective Material Weapon'
        private static string WeaponGenerator3(string[] WeaponSpecName)
        {
            return $"{RandomElem(Adjective4)} {RandomElem(WeaponMaterial)} {RandomElem(WeaponSpecName)}";
        }

        // Generate like 'Adjective, Weapon (of) Noun'
        private static string WeaponGenerator4(string[] WeaponSpecName)
        {
            return $"{RandomElem(WeaponName2)}, {RandomElem(WeaponSpecName)} {RandomElem(WeaponNoun)}";
        }
    }
}
