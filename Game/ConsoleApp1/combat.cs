using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);
namespace game
{
    public class Combat
    {
        StatViews statViews = new StatViews();
        Winning winning = new Winning();
        StatBlock statblock = new StatBlock();
        public int combatLoop()
        {
            int heroHealth = StatBlocks.statList[0].CurrentHealth;
            int monsterHealth = StatBlocks.statList.Last().Health;
            bool blockValue = false;
            Console.WriteLine($"{StatBlocks.statList[0].Name} readies his weapon and prepares for combat.");
            statViews.breakLine();
            do
            {
                statViews.healthViews(heroHealth, monsterHealth);
                int heroDamage = heroTurn();
                if (heroDamage == 0)
                {
                    blockValue = true;
                }
                else if (heroDamage > 0)
                {
                    monsterHealth = monsterHealth - heroDamage;
                }
                int monsterDamage = monsterTurn(blockValue);
                Console.WriteLine($"The Monster hits the Champion with a blow dealing {monsterDamage}.");
                heroHealth = heroHealth - monsterDamage;
            } while (heroHealth > 0 && monsterHealth > 0);
            statViews.healthViews(heroHealth, monsterHealth);
            return heroHealth;
        }

        public int heroTurn()
        {
            do
            {
                Random random = new Random();
                int damage = StatBlocks.statList[0].Strength;
                Console.WriteLine("Do yo want to attack(1) or defend(2)?");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (random.Next(1, 100) <= StatBlocks.statList[0].CritChance)
                    {
                        damage = damage * 2;
                        Console.WriteLine($"The Champion hits the monster with a mighty blow dealing {damage} damage!");
                        return (damage);
                    }
                    else
                    {
                        Console.WriteLine($"The Champion hits the monster with a blow dealing {damage} damage.");
                        return (damage);
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("The Champion raises a shield to block the monsters blow");
                    return (0);
                }
                else
                {
                    Console.WriteLine("Please input the # surrounded by parenthese next to the action you want to take");
                }
            } while (true);
        }
        public int monsterTurn(bool blockValue)
        {
            Random random = new Random();
            int damage = StatBlocks.statList.Last().Strength;
            if (random.Next(1, 100) <= StatBlocks.statList.Last().CritChance)
            {
                damage = damage * 2;
            }
            if (blockValue == true)
            {
                damage /= 2;
            }
            return (damage);
        }
    }
}