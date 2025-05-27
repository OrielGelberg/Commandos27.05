using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando1 = new Commando("John", "Shadow", Commando.Status.Waking);
            Weapon weapon1 = new Weapon("m16", "elbit", 30);
            Console.WriteLine(commando1.Code_name);
            commando1.Code_name = "x";
            Console.WriteLine(commando1.Code_name);
            Commando seaSoldier = new SeaCommando("Mike", "Wave", Commando.Status.Standing);
            Commando airSoldier = new AirCommando("Tom", "Sky", Commando.Status.Hiding);
            List<Commando> Army = new List<Commando>
            {
                commando1,
                seaSoldier,
                airSoldier
            };
            foreach (Commando soldier in Army)
            {
                soldier.Attack();    
            }
        }
    }
}
