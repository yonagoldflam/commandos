using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class Commando
    {
        private string Name;
        private string codeName { get; set; }
        public string[] Tools { get; set; } = { "hammer", "chisel", "rope", "bag", "lantern" };
        public string Status { get; set; }


        public Commando(string name, string code_name, string status)
        {
            Name = name.ToLower();
            CodeName = code_name;
            Status = status.ToLower();
        }


        public void Walk()
        {
            Status = "walk";
            Console.WriteLine("the soldier is walk");
        }


        public void Hide()
        {
            Status = "hiding";
            Console.WriteLine("the soldier is hiding");
        }


        public void Attack()
        {
            //נצמד להוראות ולא משנה סטטוס
            Console.WriteLine($"soldier {Name} is attack");
        }


        public string SayName(string commanderRank)
        {
            if (commanderRank.ToUpper() == "GENERAL")
            {
                return Name;
            }
            else if (commanderRank.ToUpper() == "COLONEL")
            {
                return CodeName;
            }
            else
            {
                return "The information is classified. You will not be able to access it!!!";
            }

        }


        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }


    }
}
