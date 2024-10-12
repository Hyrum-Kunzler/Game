
namespace game
{
    using StatBlock = (int Health, int Strength, int CritChance, string Name, int CurrentHealth);
    public static class StatBlocks
    {
        public static List<StatBlock> statList = new List<StatBlock> { };
    }
}