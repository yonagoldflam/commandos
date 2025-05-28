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
        CommandoFactory CF = new CommandoFactory(); 
        WeaponFactory WF = new WeaponFactory();
        EnemyFactory EF = new EnemyFactory();
        public void CreateObjects()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPress 1 to create a commando\r\nPress 2 to create a weapon\r\nPress 3 to create an enemy \npress another to exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        CF.CreatCommandoObject();
                        break;

                    case "2":
                        WF.CreatWeaponObject();
                        break;

                    case "3":
                        EF.CreatEnemy();
                        break;
                    
                    default:
                        flag = false;
                        break;
                }


            }
        }

        
    }
}
