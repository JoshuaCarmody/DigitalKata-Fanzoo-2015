using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKata
{
    public class DigitDisplayPatternFactory
    {
        public static readonly DigitDisplayPattern Blank = 
            DigitDisplayPattern.None;
        public static readonly DigitDisplayPattern Minus =
            DigitDisplayPattern.MiddleBar;
        public static readonly DigitDisplayPattern Zero =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.UpperLeftBar;
        public static readonly DigitDisplayPattern One = 
            DigitDisplayPattern.UpperRightBar | 
            DigitDisplayPattern.LowerRightBar;
        public static readonly DigitDisplayPattern Two =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.LowerBar;
        public static readonly DigitDisplayPattern Three =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar;
        public static readonly DigitDisplayPattern Four =
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;
        public static readonly DigitDisplayPattern Five = 
            DigitDisplayPattern.UpperBar | 
            DigitDisplayPattern.UpperLeftBar | 
            DigitDisplayPattern.MiddleBar | 
            DigitDisplayPattern.LowerRightBar | 
            DigitDisplayPattern.LowerBar;
        public static readonly DigitDisplayPattern Six =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.MiddleBar;
        public static readonly DigitDisplayPattern Seven =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;
        public static readonly DigitDisplayPattern Eight =
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar |
            DigitDisplayPattern.LowerBar |
            DigitDisplayPattern.LowerLeftBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.MiddleBar;
        public static readonly DigitDisplayPattern Nine =
            DigitDisplayPattern.MiddleBar |
            DigitDisplayPattern.UpperLeftBar |
            DigitDisplayPattern.UpperBar |
            DigitDisplayPattern.UpperRightBar |
            DigitDisplayPattern.LowerRightBar;


        public static DigitDisplayPattern FromSingleDigit(int digit)
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

        public static IEnumerable<DigitDisplayPattern> CreateEnumerable(int sourceNumber)
        {
            LinkedList<DigitDisplayPattern> returnList = new LinkedList<DigitDisplayPattern>();

            if (sourceNumber == 0)
            {
                returnList.AddFirst(Zero);
                return returnList;
            }

            bool isNegative = sourceNumber < 0;
            int remainingDigits = Math.Abs(sourceNumber);

            while (remainingDigits > 0)
            {
                int currentDigit = remainingDigits % 10;
                remainingDigits /= 10;
                returnList.AddFirst(FromSingleDigit(currentDigit));
            }

            if (isNegative)
            {
                returnList.AddFirst(Minus);
            }

            return returnList;
        }
    }
}
