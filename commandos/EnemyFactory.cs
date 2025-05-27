using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class EnemyFactory
    {
        public List<Enemy> Enemys = new List<Enemy>();
        public void CreatEnemy()
        {
            Console.WriteLine("enter the enemy name");
            Enemys.Add(new Enemy(Console.ReadLine()!));
        }
    }
}
