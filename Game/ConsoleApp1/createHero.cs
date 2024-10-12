

using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);

namespace game
{
    public class CreateHeros
    {
        public StatBlock createHero()
        {
            while (true)
            {
                Console.WriteLine("Give your champion a name");
                string heroName = Console.ReadLine();
                Random random = new Random();
                int health = random.Next(100, 151);
                int strength = random.Next(10, 21);
                int critChance = random.Next(5, 15);
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Strength: " + strength);
                Console.WriteLine("Critical strike chance: " + critChance + "%");
                Console.WriteLine();
                Console.WriteLine("Do you want to keep this Hero?");
                Console.WriteLine("Type the Hero's name if you want to keep him.");
                string keep = Console.ReadLine();
                if (keep == heroName)
                {
                    return new StatBlock(health, strength, critChance, heroName, health);
                }
            }
        }
    }
}