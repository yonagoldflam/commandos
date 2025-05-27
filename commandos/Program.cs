using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {
        public static Commando damen = new Commando("Itzchok Damen", "izik", "hiding");
        public static Weapon M16 = new Weapon("m16", "USA", 62);

        static void Main(string[] args)
        {
            Console.WriteLine(damen.CodeName);
            damen.CodeName = "Izik";
            Console.WriteLine($"name: {damen.SayName("general")}. code name: {damen.CodeName}. tools: {damen.Tools[4]}. status: {damen.Status}");
            Console.WriteLine($"name: {M16.Name}. maker: {M16.Maker}. sum balls: {M16.SumBalls}");
        }
    }

}
