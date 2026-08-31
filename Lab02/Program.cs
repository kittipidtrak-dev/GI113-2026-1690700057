//name-lastname: Kittipid Trakulpradit
//Section: 129A
//number: 1690700057
//class number: N / A 

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
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("=====BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {currentHp}/{maxHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Krint takes 60 damage");
            Console.WriteLine();
            Console.WriteLine("=====BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Hp: {currentHp}/{maxHp}");
            Console.WriteLine($"HP Percent: 47%");
        }
    }
