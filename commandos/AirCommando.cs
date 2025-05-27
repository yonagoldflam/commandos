using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class AirCommando : Commando
    {
        public AirCommando(string Name, string CodeName, string Status) : base(Name, CodeName, Status)
        {

        }


        public void Parachuting()
        {
            Console.WriteLine("parachute was made");
        }

        public override void Attack(Enemy e)
        {
            Console.WriteLine($"air commando soldier attacks {e}");
        }
    }
}
