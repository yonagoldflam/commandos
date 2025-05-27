using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class Soldier
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string[] Tools { get; set; } = { "hammer", "chisel", "rope", "bag", "lantern" };
        public string Status { get; set; }


        public Soldier(string name, int id, string status)
        {
            Name = name.ToLower();
            Id = id;
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
    }
}
