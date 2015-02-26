using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKata
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testNumbers = new int[] { 0, 112, 2015, 32767 };
            var renderer = new DigitDisplayAsciiRenderer(2,2);

            foreach (int i in testNumbers)
            {
                Console.WriteLine("Source Number: " + i.ToString());
                Console.WriteLine("Output:\n");
                Console.WriteLine(renderer.Render(DigitDisplayPatternFactory.CreateEnumerable(i)));
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }
    }
}
