using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Knife : IWeapon
    {
        private string name;
        private string metalType;
        private string manufacturer;
        private string color;
        private double weight;

        public string Name { get => name; }
        public string MetalType { get => metalType; }
        public string Manufacturer { get => manufacturer; }
        public string Color { get => color; }
        public double Weight { get => weight; }

        public Knife(string name, string metalType, string manufacturer, string color, double weight)
        {
            this.name = name;
            this.metalType = metalType;
            this.manufacturer = manufacturer;
            this.color = color;
            this.weight = weight;
        }

        public void Stab()
        {
            Console.WriteLine($"{name} knife stabs the target with {metalType} blade!");
        }

        public void Use()
        {
            Stab();
        }
    }
}
