using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {
        static Commando Damen;
        static Weapon M16;
        static AirCommando Maglan;
        static SeaCommando Shayettet;

        static void Main(string[] args)
        {
            intialization();
            Console.WriteLine(Damen.CodeName);
            Damen.CodeName = "Izik";
            Console.WriteLine($"name: {Damen.SayName("general")}. code name: {Damen.CodeName}. tools: {Damen.Tools[4]}. status: {Damen.Status}");
            Console.WriteLine($"name: {M16.Name}. maker: {M16.Maker}. sum balls: {M16.SumBalls}");
            Console.WriteLine($"name: {Maglan.SayName("general")}. code name: {Maglan.CodeName}. tools: {Maglan.Tools[4]}. status: {Maglan.Status}");
            Console.WriteLine($"name: {Shayettet.SayName("general")}. code name: {Shayettet.CodeName}. tools: {Shayettet.Tools[4]}. status: {Shayettet.Status}");
        }

        static void intialization()
        {
            Damen = new Commando("Itzchok Damen", "izik", "hiding");
            M16 = new Weapon("m16", "USA", 62);
            Maglan = new AirCommando("avraham", "avi", "hiding");
            Shayettet = new SeaCommando("eliyahu", "eli", "hiding");
        }
    }

}
