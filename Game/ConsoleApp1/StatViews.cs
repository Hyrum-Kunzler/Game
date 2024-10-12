

namespace game
{
    public class StatViews
    {
        public void healthViews(int heroHealth, int monsterHealth)
        {
            Console.WriteLine($"{StatBlocks.statList[0].Name}'s HP");
            Console.WriteLine("---------");
            Console.WriteLine($"{heroHealth} / {StatBlocks.statList[0].Health}");
            Console.WriteLine();
            Console.WriteLine($"{StatBlocks.statList.Last().Name}'s HP");
            Console.WriteLine("-------------");
            Console.WriteLine($"{monsterHealth} / {StatBlocks.statList.Last().Health}");
        }
        public void heroStatView()
        {
            Console.WriteLine("Champion Name: " + StatBlocks.statList[0].Name);
            Console.WriteLine("Health: " + StatBlocks.statList[0].CurrentHealth + "/" + StatBlocks.statList[0].Health);
            Console.WriteLine("Strength: " + StatBlocks.statList[0].Strength);
            Console.WriteLine("Critical strike chance: " + StatBlocks.statList[0].CritChance + "%");
        }
        public void breakLine()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}