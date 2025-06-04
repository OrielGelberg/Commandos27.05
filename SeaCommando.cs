using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string code_name, Status status) : base(name, code_name, status)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"{Code_name} is swimming.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Code_name} is attacking from the sea.");
        }


    }
}
