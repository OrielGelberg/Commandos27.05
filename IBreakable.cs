using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal interface IBreakable
    {
        string Status { get; set; }
        int MaxHits { get; }
        int CurrentHits { get; set; }
        void Hit();
        bool IsBroken();
    }
}
