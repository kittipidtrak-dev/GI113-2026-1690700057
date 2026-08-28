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

            string characterOneName = "Gandeeva";
            char characterOneRank = 'A';
            int characterOneLevel = 5;
            int characterOneMaxHp = 120;
            int characterOneCurrentHp = 120;
            int characterOneDamageTaken = 15;
            float characterOneAttackPower = 35.0f;
            double characterOneCritMultiplier = 2.0;
            bool IsLongRange = true;

            Console.WriteLine("===== Gandeeva STATUS: INITIAL =====");
            Console.WriteLine($"Name: {characterOneName}");
            Console.WriteLine($"Rank: {characterOneRank}");
            Console.WriteLine($"Level: {characterOneLevel}");
            Console.WriteLine($"HP: {characterOneCurrentHp} / {characterOneMaxHp}");
            Console.WriteLine($"Attack Power: {characterOneAttackPower}");
            Console.WriteLine($"Crit Multiplier: {characterOneCritMultiplier}");
            Console.WriteLine($"Is Long Range: {IsLongRange}");

            /* Character two */

            string characterTwoName = "Vermillion";
            char characterTwoRank = 'C';
            int characterTwoLevel = 4;
            int characterTwoMaxHp = 190;
            int characterTwoCurrentHp = 175;
            int characterTwoDamageTaken = 60;
            float characterTwoAttackPower = 20.5f;
            double characterTwoCritMultiplier = 1.15;
            bool IsMelee = true;

            Console.WriteLine("===== Vermillion STATUS: INITIAL =====");
            Console.WriteLine($"Name: {characterTwoName}");
            Console.WriteLine($"Rank: {characterTwoRank}");
            Console.WriteLine($"Level: {characterTwoLevel}");
            Console.WriteLine($"HP: {characterTwoCurrentHp} / {characterTwoMaxHp}");
            Console.WriteLine($"Attack Power: {characterTwoAttackPower}");
            Console.WriteLine($"Crit Multiplier: {characterTwoCritMultiplier}");
            Console.WriteLine($"Is Melee: {IsMelee}");

            /* Character three */

            string characterThreeName = "Nirvana Jheva";
            char characterThreeRank = 'A';
            int characterThreeLevel = 6;
            int characterThreeMaxHp = 130;
            int characterThreeCurrentHp = 130;
            int characterThreeDamageTaken = 0;
            float characterThreeAttackPower = 15.0f;
            double characterThreeCritMultiplier = 1;
            bool IsSummmoner = true;

            Console.WriteLine("===== Nirvana Jheva STATUS: INITIAL =====");
            Console.WriteLine($"Name: {characterThreeName}");
            Console.WriteLine($"Rank: {characterThreeRank}");
            Console.WriteLine($"Level: {characterThreeLevel}");
            Console.WriteLine($"HP: {characterThreeCurrentHp} / {characterThreeMaxHp}");
            Console.WriteLine($"Attack Power: {characterThreeAttackPower}");
            Console.WriteLine($"Crit Multiplier: {characterThreeCritMultiplier}");
            Console.WriteLine($"Is Summoner: {IsSummmoner}");

            /* Character four */

            string characterFourName = "Bavsargra";
            char characterFourRank = 'A';
            int characterFourLevel = 5;
            int characterFourMaxHp = 235;
            int characterFourCurrentHp = 170;
            int characterFourDamageTaken = 65;
            float characterFourAttackPower = 20.0f;
            double characterFourCritMultiplier = 1.50;
            bool IsTank = true;

            Console.WriteLine("===== Bavsargra STATUS: INITIAL =====");
            Console.WriteLine($"Name: {characterFourName}");
            Console.WriteLine($"Rank: {characterFourRank}");
            Console.WriteLine($"Level: {characterFourLevel}");
            Console.WriteLine($"HP: {characterFourCurrentHp} / {characterFourMaxHp}");
            Console.WriteLine($"Attack Power: {characterFourAttackPower}");
            Console.WriteLine($"Crit Multiplier: {characterFourCritMultiplier}");
            Console.WriteLine($"Is Tank: {IsTank}");
        }
    }
} 