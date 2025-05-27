using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {
        static Commando Damen;
        static Weapon M16;
        static AirCommando Maglan;
        static SeaCommando Shayettet;
        static Commando[] Soldiers;
        static Enemy Ahmmad;

        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateObjects();


        }


    }

}
