using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string code_name, Status status) : base(name, code_name, status)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"The soldier {Code_name} is ready to parachute.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Code_name} is attacking from the air.");
        }
    }
}
