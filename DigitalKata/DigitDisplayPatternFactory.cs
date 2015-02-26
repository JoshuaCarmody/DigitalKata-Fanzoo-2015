using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKata
{
    public class DigitDisplayPatternFactory
    {
        private static readonly DigitDisplayPattern Blank = 
            DigitDisplayPattern.None;
        private static readonly DigitDisplayPattern Zero =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.UpperLeftBar;
        private static readonly DigitDisplayPattern One = 
            DigitDisplayPattern.UpperLeftBar | 
            DigitDisplayPattern.LowerLeftBar;
        private static readonly DigitDisplayPattern Two =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.LowerBar;
        private static readonly DigitDisplayPattern Three =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar;
        private static readonly DigitDisplayPattern Four =
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;
        private static readonly DigitDisplayPattern Five = 
            DigitDisplayPattern.UpperBar | 
            DigitDisplayPattern.UpperLeftBar | 
            DigitDisplayPattern.MiddleBar | 
            DigitDisplayPattern.LowerRightBar | 
            DigitDisplayPattern.LowerBar;
        private static readonly DigitDisplayPattern Six =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.MiddleBar;
        private static readonly DigitDisplayPattern Seven =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;
        private static readonly DigitDisplayPattern Eight =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.MiddleBar;
        private static readonly DigitDisplayPattern Nine =
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;


        public static DigitDisplayPattern FromSingleDigitInt(int digit)
        {
            switch (digit)
            {
                case 0:
                    return Zero;
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                case 5:
                    return Five;
                case 6:
                    return Six;
                case 7:
                    return Seven;
                case 8:
                    return Eight;
                case 9:
                    return Nine;
                default:
                    throw new ArgumentOutOfRangeException("digit", "Expected: 0-9. Actual: " + digit);
            }
        }
    }
}
