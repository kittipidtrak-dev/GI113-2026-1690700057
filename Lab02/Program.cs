/*
Student ID    :  1690700057
Name          :  Kittipid Trakulpradit
Section       :  129A
Class number  :  N/A
Course        :  GI113 Computer Programming (GI)
*/
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            int damageTaken = 60;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine("");
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("");
            Console.WriteLine($"Kirin takes {damageTaken} damage!");
            Console.WriteLine("");
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine("HP: 115/240");
            Console.WriteLine("HP: 47%");
            Console.WriteLine("");

            /* Part two */
            /* Character one */

            string CharacteroneName = "Gandeeva";
            char CharacteroneRank = 'A';
            int CharacteroneLevel = 5;
            int CharacteroneMaxHp = 120;
            int CharacteroneCurrentHp = 120;
            int CharacteroneDamageTaken = 15;
            float CharacteroneAttackPower = 35.0f;
            double CharacteroneCritMultiplier = 2.0;
            bool LongRange = true;

            Console.WriteLine("===== Gandeeva STATUS: INITIAL =====");
            Console.WriteLine($"Name: {CharacteroneName}");
            Console.WriteLine($"Rank: {CharacteroneRank}");
            Console.WriteLine($"Level: {CharacteroneLevel}");
            Console.WriteLine($"HP: {CharacteroneCurrentHp} / {CharacteroneMaxHp}");
            Console.WriteLine($"Attack Power: {CharacteroneAttackPower}");
            Console.WriteLine($"Crit Multiplier: {CharacteroneCritMultiplier}");
            Console.WriteLine($"Is Boss: {LongRange}");

            /* Character two */

            string CharactertwoName = "Vermillion";
            char CharactertwoRank = 'C';
            int CharactertwoLevel = 4;
            int CharactertwoMaxHp = 190;
            int CharactertwoCurrentHp = 175;
            int CharactertwoDamageTaken = 60;
            float CharactertwoAttackPower = 20.5f;
            double CharactertwoCritMultiplier = 1.15;
            bool Melee = true;

            Console.WriteLine("===== Vermillion STATUS: INITIAL =====");
            Console.WriteLine($"Name: {CharactertwoName}");
            Console.WriteLine($"Rank: {CharactertwoRank}");
            Console.WriteLine($"Level: {CharactertwoLevel}");
            Console.WriteLine($"HP: {CharactertwoCurrentHp} / {CharactertwoMaxHp}");
            Console.WriteLine($"Attack Power: {CharactertwoAttackPower}");
            Console.WriteLine($"Crit Multiplier: {CharactertwoCritMultiplier}");
            Console.WriteLine($"Is Boss: {Melee}");

            /* Character three */

            string CharacterthreeName = "Nirvana Jheva";
            char CharacterthreeRank = 'A';
            int CharacterthreeLevel = 6;
            int CharacterthreeMaxHp = 130;
            int CharacterthreeCurrentHp = 130;
            int CharacterthreeDamageTaken = 0;
            float CharacterthreeAttackPower = 15.0f;
            double CharacterthreeCritMultiplier = 1;
            bool Summoner = true;

            Console.WriteLine("===== Nirvana Jheva STATUS: INITIAL =====");
            Console.WriteLine($"Name: {CharacterthreeName}");
            Console.WriteLine($"Rank: {CharacterthreeRank}");
            Console.WriteLine($"Level: {CharacterthreeLevel}");
            Console.WriteLine($"HP: {CharacterthreeCurrentHp} / {CharacterthreeMaxHp}");
            Console.WriteLine($"Attack Power: {CharacterthreeAttackPower}");
            Console.WriteLine($"Crit Multiplier: {CharacterthreeCritMultiplier  }");
            Console.WriteLine($"Is Boss: {Summoner}");

            /* Character four */

            string CharacterfourName = "Bavsargra";
            char CharacterfourRank = 'A';
            int CharacterfourLevel = 5;
            int CharacterfourMaxHp = 235;
            int CharacterfourCurrentHp = 170;
            int CharacterfourDamageTaken = 65;
            float CharacterfourAttackPower = 20.0f;
            double CharacterfourCritMultiplier = 1.50;
            bool Tank = true;

            Console.WriteLine("===== Bavsargra STATUS: INITIAL =====");
            Console.WriteLine($"Name: {CharacterfourName}");
            Console.WriteLine($"Rank: {CharacterfourRank}");
            Console.WriteLine($"Level: {CharacterfourLevel}");
            Console.WriteLine($"HP: {CharacterfourCurrentHp} / {CharacterfourMaxHp}");
            Console.WriteLine($"Attack Power: {CharacterfourAttackPower}");
            Console.WriteLine($"Crit Multiplier: {CharacterfourCritMultiplier}");
            Console.WriteLine($"Is Boss: {Tank}");
        }
    }
} 