using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Weapon : IWeapon, IShootable
    {
        private string name;
        private string manufacturer;
        private int numberOfBullets;

        public string Name { get => name; }
        public string Manufacturer { get => manufacturer; }
        public int Bullets { get => numberOfBullets; set => numberOfBullets = value; }


        public Weapon(string name, string manufacturer, int numberOfBullets)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.numberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            if (CanShoot())
            {
                Console.WriteLine($"{name} is shooting.");
                numberOfBullets--;
            }
            else
            {
                Console.WriteLine($"{name} has no bullets left.");
            }
        }

        public bool CanShoot()
        {
            return numberOfBullets > 0;
        }

        public void Use()
        {
            Shoot();
        }
    }
}
