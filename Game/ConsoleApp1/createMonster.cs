using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);
namespace game
{
    public class CreateMonsters
    {
        List<string> namesList = new List<string> { "Goblin", "Ogre", "Troll", "Skeleton", "Zombie", "Slime", "Bat", "Wraith", "Spider", "Imp", "Gargoyle", "Ghost", "Minotaur", "Harpy", "Golem", "Serpent", "Lizardman", "Wyvern", "Dire Wolf", "Shadow Beast" };
        public StatBlock createMonster(int round)
        {
            Random random = new Random();
            string MonsterName = namesList[random.Next(namesList.Count)];
            int health = random.Next(80 * round, 131 * round);
            int strength = random.Next(5 * round, 15 * round);
            int critChance = random.Next(5 * round, 10 * round);
            return new StatBlock(health, strength, critChance, MonsterName, health);
        }
    }
}