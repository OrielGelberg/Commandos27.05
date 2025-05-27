using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Weapon
    {
        private string name;
        private string manufacturer;
        private int numberOfBullets;

        public Weapon(string name, string manufacturer, int numberOfBullets)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.numberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            if (numberOfBullets > 0)
            {
                Console.WriteLine($"{name} is shooting.");
                numberOfBullets--;
            }
            else
            {
                Console.WriteLine($"{name} has no bullets left.");
            }
        }
    }
}
