using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class CommandoFactory
    {
        private List<Commando> commandos = new List<Commando>();
        public CommandoFactory() { }
        //public Commando CreateCommando(string type, string name, string codeName, Commando.Status status)
        //{
        //    switch (type)
        //    {
        //        case "Commando":
        //            Commando commando = new Commando(name, codeName, status);
        //            commandos.Add(commando);
        //            return commando;
        //        case "SeaCommando":
        //            SeaCommando seaCommando = new SeaCommando(name, codeName, status);
        //            commandos.Add(seaCommando);
        //            return seaCommando;
        //        case "AirCommando":
        //            AirCommando airCommando = new AirCommando(name, codeName, status);
        //            commandos.Add(airCommando);
        //            return airCommando;
        //        default:
        //            throw new ArgumentException("Invalid commando type");

        //    }
        //}
        public Commando CreateCommando(string type, string name, string codeName, Commando.Status status)
        {
            Commando newCommando = null;

            switch (type.ToLower())
            {
                case "commando":
                    newCommando = new Commando(name, codeName, status);
                    break;
                case "seacommando":
                    newCommando = new SeaCommando(name, codeName, status);
                    break;
                case "aircommando":
                    newCommando = new AirCommando(name, codeName, status);
                    break;
                default:
                    throw new ArgumentException($"Invalid commando type: {type}");
            }

            if (newCommando != null)
            {
                commandos.Add(newCommando);
                Console.WriteLine($"{type} {codeName} has been recruited!");
            }

            return newCommando;
        }


        public List<Commando> GetAllCommandos()
        {
            return new List<Commando>(commandos);
        }

        public int GetCommandoCount()
        {
            return commandos.Count;
        }

    }
}
