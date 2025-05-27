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
        public string Status { get; set; }
        public Enemy(string name, string status = "live")
        {
            Name = name;
            Status = status;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy!!!!");
        }

    }
}
