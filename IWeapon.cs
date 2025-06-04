using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal interface IWeapon
    {
        string Name { get; }
        void Use();
    }
}
