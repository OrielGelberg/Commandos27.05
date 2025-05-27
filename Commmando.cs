using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Commando
    {
        private string name;
        public string Code_name { get; set; }
        private string[] tools;
        private Status status;

        internal enum Status
        {
            Waking,
            Standing,
            Hiding,
        };

        public Commando(string name, string code_name, Status status)
        {
            this.name = name;
            this.Code_name = code_name;
            this.status = status;
            tools = new string [] { "Hammer", "chisel", "rope", "bag", "water bottle"};
            
        }

        public void printWaking()
        {
            Console.WriteLine($"{name} is waking up.");
            status = Status.Waking;
        }    
        public void printHiding()
        {
            Console.WriteLine($"{name} is hiding.");
            status = Status.Hiding;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Code_name} is attacking.");
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank.Equals("General"))
                return $"{name} is a name of a commando.";
            else if (commanderRank.Equals("Colonel"))
                return $"The code name of the commando is {Code_name}.";
            else
                return "Invalid rank provided.";
        }

    }
}
