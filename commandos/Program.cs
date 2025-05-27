using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {
        public static Soldier damen = new Soldier("Itzchok Damen", 2355144, "hiding");
        public static Weapon M16 = new Weapon("m16", "USA", 62);

        static void Main(string[] args)
        {
            Console.WriteLine($"name: {damen.Name}. id: {damen.Id}. tools: {damen.Tools}. status: {damen.Name}");
            Console.WriteLine($"name: {M16.Name}. maker: {M16.Maker}. sum balls: {M16.SumBalls}");
        }
    }

}
