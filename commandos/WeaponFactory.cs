using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class WeaponFactory
    {

        
        public List<Weapon> Weapons = new List<Weapon>();
        public void CreatWeaponObject()
        {
            while (true)
            {
                Console.WriteLine("Press 1 to create M16\r\nPress 2 to create MK47\r\npres 3 to exit");
                string choose = Console.ReadLine()!;

                if (choose != "1" && choose != "2")
                {
                    break;
                }
                Console.WriteLine("enter the name");
                string name = Console.ReadLine()!;
                Console.WriteLine("enter the maker");
                string maker = Console.ReadLine()!;
                Console.WriteLine("enter the balls");
                int balls = int.Parse(Console.ReadLine()!);

                switch (choose)
                {
                    case "1":
                        Weapons.Add(new M16(name, maker, balls));
                        Console.WriteLine("The object is saved in the system (:\n");
                        break;

                    case "2":
                        Weapons.Add(new MK47(name, maker, balls));
                        Console.WriteLine("The object is saved in the system (:\n");
                        break;
                }
            }
        }
        
    }
}
