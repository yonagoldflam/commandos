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
                Console.WriteLine("enter the name");
                string name = Console.ReadLine()!;
                Console.WriteLine("enter the maker");
                string maker = Console.ReadLine()!;
                Console.WriteLine("enter the balls");
                int balls = int.Parse(Console.ReadLine()!);
                
                Weapons.Add(new Weapon(name,maker,balls));
            }
        
    }
}
