using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string Name, string code_name, string Status) : base(Name, code_name, Status)
        {

        }


        public void Swimming()
        {
            Console.WriteLine("Swimming was performed");
        }
    }
}
