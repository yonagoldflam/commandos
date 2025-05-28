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
        public string[] DbTools { get; set; } = { "hammer", "chisel", "rope", "bag", "lantern" };
        public List<string> Tools { get; set; } = new List<string>();
        public string Status { get; set; }

         
        public Commando(string name, string code_name, string status)
        {
            Name = name.ToLower();
            CodeName = code_name;
            Status = status.ToLower();
            AddTools();
            
        }

        public void AddTools()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Press 1 to add Hammer\r\nPress 2 to add Chisel\r\nPress 3 to add Rope\r\nPress 4 to add Bag\r\nPress 5 to add lantern\r\nTo finish - press any other key");
                switch (Console.ReadLine())
                {
                    case "1":
                        Tools.Add(DbTools[0]);
                        break;

                    case "2":
                        Tools.Add(DbTools[1]);
                        break;

                    case "3":
                        Tools.Add(DbTools[2]);
                        break;

                    case "4":
                        Tools.Add(DbTools[3]);
                        break;

                    case "5":
                        Tools.Add(DbTools[4]);
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
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


        public virtual void Attack(Enemy enemy)
        {
            bool succeeded = enemy.SubLive();


            //נצמד להוראות ולא משנה סטטוס            
            Console.WriteLine(succeeded ? $"soldier {Name} is attacking {enemy.Name}": "error");

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
