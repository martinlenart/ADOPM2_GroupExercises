using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public enum DiceFace { One = 1, Two, Three, Four, Five, Six }
    internal interface IDice
    {
        public DiceFace Face { get; init; }
    }
}
