using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Enemy
    {
        private string name;
        private int life = 100;
        private string lifeStatus = "alive";


        public string Name { get => name; }
        public int Life { get => life; set => life = value; }
        public string LifeStatus { get => lifeStatus; set => lifeStatus = value; }



        public Enemy(string name)
        {
            this.name = name;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy!!!");
        }

        public void TakeDamage(int damage)
        {
            life -= damage;
            if (life <= 0)
            {
                life = 0;
                lifeStatus = "dead";
                Console.WriteLine($"{name} has been defeated!");
            }
        }

    }
}
