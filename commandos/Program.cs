using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateObjects();
            game.TestObjects();
        }


    }

}
