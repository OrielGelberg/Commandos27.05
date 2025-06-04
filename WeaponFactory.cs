using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class WeaponFactory
    {
       private List<IWeapon> weapons = new List<IWeapon>();
        public WeaponFactory() { }
        public Weapon CreateFirearm(string name, string manufacturer, int numberOfBullets)
        {
            Weapon weapon = new Weapon(name, manufacturer, numberOfBullets);
            weapons.Add(weapon);
            Console.WriteLine($"Firearm {name} created by {manufacturer} with {numberOfBullets} bullets.");
            return weapon;
        }


        public Stone CreateStone(string name, double weight, string color)
        {
            Stone stone = new Stone(name, weight, color);
            weapons.Add(stone);
            Console.WriteLine($"Stone {name} created with weight {weight} and color {color}.");
            return stone;
        }


        public Knife CreateKnife(string name, string metalType, string manufacturer, string color, double weight)
        {
            Knife knife = new Knife(name, metalType, manufacturer, color, weight);
            weapons.Add(knife);
            Console.WriteLine($"Knife {name} made of {metalType} by {manufacturer} with color {color} and weight {weight} created.");
            return knife;
        }


        public List<IWeapon> GetAllWeapons()
        {
            return new List<IWeapon>(weapons);
        }


        public int GetWeaponCount()
        {
            return weapons.Count;
        }




    }
}
