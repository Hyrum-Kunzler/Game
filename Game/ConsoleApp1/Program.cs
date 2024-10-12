using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);
namespace game
{
    public class Program
    {
        Combat combat = new Combat();
        StatViews statViews = new StatViews();
        Winning winning = new Winning();
        CreateHeros createHero = new CreateHeros();
        CreateMonsters createMonster = new CreateMonsters();
        public void Start()
        {
            int round = 1;
            StatBlock monster = createMonster.createMonster(round);
            StatBlock hero = createHero.createHero();
            StatBlocks.statList.Add(hero);
            StatBlocks.statList.Add(monster);
            Console.WriteLine($"The brave champion {StatBlocks.statList[0].Name} will be fighting the {StatBlocks.statList.Last().Name}.");
            int win = combat.combatLoop();
            while (win > 0)
            {
                winning.winn(win);
                statViews.breakLine();
                round++;
                StatBlocks.statList.RemoveAt(1);
                StatBlock newMonster = createMonster.createMonster(round);
                StatBlocks.statList.Add(newMonster);
                win = combat.combatLoop();
            }
            Console.WriteLine("You died. Sounds like a skill issue");
            Console.WriteLine("Get good.");
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
    }
}