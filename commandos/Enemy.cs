using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Lives { get; set; } = 100;
        public bool Status { get; set; }
        public Enemy(string name, bool status =true)
        {
            Name = name;
            Status = status;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy!!!!");
        }

        public bool SubLive()
        {
            if (Status)
            {
                Lives -= 1;
                return true;
            }

            else
            {
                Console.WriteLine("The enemy is die alrady");
                return false;
            }
        }

    }
}
