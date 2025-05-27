using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
     public class Weapon
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public int SumBalls { get; set; }


        public Weapon(string name, string maker, int balls)
        {
            Name = name.ToLower();
            Maker = maker.ToLower();
            SumBalls = balls;
        }


        public void Shoot()
        {
            if (SumBalls > 0)
            {
                SumBalls -= 1;
                Console.WriteLine("shoot done!!!!");
            }
            else
            {
                Console.WriteLine("There are not enough balls!!");
            }


        }



    }
}
