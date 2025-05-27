using System.Runtime.CompilerServices;

namespace commandos
{
    internal class Program
    {
        public static Soldier damen = new Soldier("Itzchok Damen", 2355144, "hiding");
        
        static void Main(string[] args)
        {
            Console.WriteLine($"name: {damen.Name}. id: {damen.Id}. tools: {damen.Tools}. status: {damen.Name}");
        }
    }

}
