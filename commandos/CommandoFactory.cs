using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class CommandoFactory
    {
        public List<Commando> Commandos = new List<Commando>();
        public void CreatCommandoObject()
        {
            Console.WriteLine("Press 1 to create a commando\r\nPress 2 to create an air commando\r\nPress 3 to create a sea commando");
            string TypeChoose = Console.ReadLine()!;
            
            Console.WriteLine("enter the name");
            string Name = Console.ReadLine()!;
            Console.WriteLine("enter the CodeName");
            string CodeName = Console.ReadLine()!;
            Console.WriteLine("enter the Status");
            string Status = Console.ReadLine()!;

            switch (TypeChoose)
            {
                case "1":
                    Commandos.Add(new Commando(Name, CodeName, Status));
                    break;

                case "2":
                    Commandos.Add(new AirCommando(Name, CodeName, Status));
                    break;

                case "3":
                    Commandos.Add(new SeaCommando(Name, CodeName, Status));
                    break;
            }
            
        }
    }
}
