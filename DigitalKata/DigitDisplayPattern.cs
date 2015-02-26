using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKata
{
    [Flags]
    public enum DigitDisplayPattern
    {
        None = 0,
        UpperBar = 1,
        UpperRightBar = 2,
        LowerRightBar = 4,
        LowerBar = 8,
        LowerLeftBar = 16,
        UpperLeftBar = 32,
        MiddleBar = 64
    }
}
