using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Stone : IWeapon ,IBreakable
    {

        private string name;
        private double weight;
        private string color;
        private string status = "whole";
        private int maxHits = 5;
        private int currentHits = 0;

        public string Name { get => name; }
        public double Weight { get => weight; }
        public string Color { get => color; }
        public string Status { get => status; set => status = value; }
        public int MaxHits { get => maxHits; }
        public int CurrentHits { get => currentHits; set => currentHits = value; }

        public Stone(string name, double weight, string color)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
        }

        public void Hit()
        {
            if (!IsBroken())
            {
                currentHits++;
                Console.WriteLine($"{name} stone hits the target! ({currentHits}/{maxHits} hits)");

                if (IsBroken())
                {
                    status = "broken";
                    Console.WriteLine($"{name} stone is now broken!");
                }
            }
            else
            {
                Console.WriteLine($"{name} stone is broken and cannot be used.");
            }
        }

        public bool IsBroken()
        {
            return currentHits >= maxHits;
        }

        public void Use()
        {
            Hit();
        }
    }
}
