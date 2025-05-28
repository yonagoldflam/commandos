using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class Game
    {
        //אפשר לגשת לרשימת האובייקטים על ידי אובייקטי הפקטוריז
        CommandoFactory commandoFactory = new CommandoFactory(); 
        WeaponFactory weaponFactory = new WeaponFactory();
        EnemyFactory enemyFactory = new EnemyFactory();
        public void CreateObjects()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPress 1 to create a commando\r\nPress 2 to create a weapon\r\nPress 3 to create an enemy \npress another to exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        commandoFactory.CreatCommandoObject();
                        break;

                    case "2":
                        weaponFactory.CreatWeaponObject();
                        break;

                    case "3":
                        enemyFactory.CreatEnemy();
                        break;
                    
                    default:
                        flag = false;
                        break;
                }
            }
        }

        public void TestObjects()
        {
            Console.WriteLine("press 1 to show commandos\npress 2 to show Weapons \npress 3 to show Enemys");
            switch (Console.ReadLine())
            {
                case "1":
                    foreach (var c in commandoFactory.Commandos)
                    {
                        Console.WriteLine("enter rank");
                        Console.WriteLine(c.SayName(Console.ReadLine()!));
                        foreach (var i in c.Tools)
                        {
                            Console.WriteLine(i);
                        }
                        c.Attack(enemyFactory.Enemys[0]);
                    }
                    break;

                case "2":
                    foreach (var c in weaponFactory.Weapons)
                    {
                        Console.WriteLine(c.Name);
                        Console.WriteLine(c.SumBalls);
                        c.Shoot();
                    }
                    break;

                case "3":
                    foreach (var c in enemyFactory.Enemys)
                    {
                        Console.WriteLine(c.Lives);
                        c.Shout();
                    }
                    break;
            }
        }
    }
}
