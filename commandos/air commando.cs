using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class AirCommando : Commando
    {
        public AirCommando(string Name, string code_name, string Status) : base(Name, code_name, Status)
        {

        }


        public void Parachuting()
        {
            Console.WriteLine("parachute was made");
        }
    }
}
