
using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);
namespace game
{
    public class Winning
    {
        StatViews statViews = new StatViews();
        public void winn(int damage)
        {
            Console.WriteLine("You Won! You now get to fight the next enemy!");
            Console.WriteLine("Heres your reward for the previous fight first.");
            Console.WriteLine("choose between Strengthen(1) or Heal(2).");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                StatBlocks.statList[0] = strengthenStat(StatBlocks.statList[0], damage);
                Console.WriteLine("You feel power surging through you as your stats increase!");
            }
            else if (choice == "2")
            {
                StatBlocks.statList[0] = Heal(StatBlocks.statList[0]);
                Console.WriteLine("You consume a Healing potion restoring you to full health!");
            }
            else
            {
                Console.WriteLine("Please input the # surrounded by parenthese next to the action you want to take");
            }
            statViews.heroStatView();
        }
        public static StatBlock strengthenStat(StatBlock stats, int damage)
        {
            Random random = new Random();
            int stat = random.Next(1, 4);
            if (stats.CritChance > 99)
            {
                stat = random.Next(1, 3);
            }
            if (stat == 1)
            {
                stats.Health = stats.Health + 500;
                Console.WriteLine("you increased your Health by 500!");
            }
            else if (stat == 2)
            {
                stats.Strength = stats.Strength + 100;
                Console.WriteLine("you increased your Strength by 100!");
            }
            else if (stat == 3)
            {
                stats.CritChance = 100;
                Console.WriteLine("you increased your Critical strike chance by 100!");
            }
            stats.CurrentHealth = stats.Health - damage;
            return new StatBlock(stats.Health, stats.Strength, stats.CritChance, stats.Name, stats.CurrentHealth);
        }
        public static StatBlock Heal(StatBlock stats)
        {
            stats.CurrentHealth = stats.Health;
            return new StatBlock(stats.Health, stats.Strength, stats.CritChance, stats.Name, stats.CurrentHealth);
        }

    }
}