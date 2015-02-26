using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKata
{
    public class DigitDisplayAsciiRenderer
    {
        private int ScaleX;
        private int ScaleY;
        private int SpaceWidth;
        private int CharWidth;
        private int CharHeight;

        public DigitDisplayAsciiRenderer(int scaleX, int scaleY)
        {
            ScaleX = scaleX;
            ScaleY = scaleY;

            SpaceWidth = Math.Max(ScaleX / 2, 1);
            CharWidth = ScaleX + 2 + SpaceWidth;
            CharHeight = (ScaleY * 2) + 1;
        }

        public string Render(IEnumerable<DigitDisplayPattern> digits)
        {

            char[,] asciiCanvas = new char[CharWidth * digits.Count(), CharHeight];
            int x = 0;

            foreach (var digit in digits)
            {                
                Render(asciiCanvas, digit, x);
                x += CharWidth;
            }

            StringBuilder returnValue = new StringBuilder();
            for (int j = 0; j < CharHeight; j++)
            {
                for (int i = 0; i < (CharWidth * digits.Count()); i++)
                {
                    returnValue.Append(asciiCanvas[i, j]);
                }
                returnValue.AppendLine(string.Empty);
            }

            return returnValue.ToString();
        }

        private void Render(char[,] asciiCanvas, DigitDisplayPattern digit, int x)
        {
            if (digit.HasFlag(DigitDisplayPattern.UpperBar))
            {
                for (int i = 0; i < ScaleX; i++)
                {
                    asciiCanvas[i + x + 1, 0] = '_';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.LowerBar))
            {
                for (int i = 0; i < ScaleX; i++)
                {
                    asciiCanvas[i + x + 1, CharHeight - 1] = '_';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.MiddleBar))
            {
                for (int i = 0; i < ScaleX; i++)
                {
                    asciiCanvas[i + x + 1, ScaleY] = '_';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.UpperRightBar))
            {
                for (int i = 0; i < ScaleY; i++)
                {
                    asciiCanvas[x + ScaleX + 1, i + 1] = '|';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.LowerRightBar))
            {
                for (int i = 0; i < ScaleY; i++)
                {
                    asciiCanvas[x + ScaleX + 1, i + ScaleY + 1] = '|';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.UpperLeftBar))
            {
                for (int i = 0; i < ScaleY; i++)
                {
                    asciiCanvas[x, i + 1] = '|';
                }
            }
            if (digit.HasFlag(DigitDisplayPattern.LowerLeftBar))
            {
                for (int i = 0; i < ScaleY; i++)
                {
                    asciiCanvas[x, i + ScaleY + 1] = '|';
                }
            }
        }
    }
}
