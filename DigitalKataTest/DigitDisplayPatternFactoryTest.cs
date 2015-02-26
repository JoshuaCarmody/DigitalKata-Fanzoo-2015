using DigitalKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKataTest
{
    [TestClass]
    public class DigitDisplayPatternFactoryTest
    {
        [TestMethod]
        public void FromSingleDigitInt_Should_Return_Value_For_Each_Number_1_Through_9()
        {
            var listOfEnums = new List<DigitDisplayPattern>();

            for(int i=0;i<10;i++)
            {
                listOfEnums.Add(DigitDisplayPatternFactory.FromSingleDigitInt(i));
            }

            Assert.AreEqual(10, listOfEnums.Count);
            Assert.IsFalse(listOfEnums.Contains(0));
        }

        [TestMethod]
        public void FromSingleDigitInt_Should_Throw_Exception_Given_10()
        {
            bool errorWasThrown = false;
            try
            {
                DigitDisplayPattern digit = DigitDisplayPatternFactory.FromSingleDigitInt(10);
            }
            catch
            {
                errorWasThrown = true;
            }
            Assert.IsTrue(errorWasThrown);
        }

        [TestMethod]
        public void FromSingleDigitInt_Should_Throw_Exception_Given_Minus1()
        {
            bool errorWasThrown = false;
            try
            {
                DigitDisplayPattern digit = DigitDisplayPatternFactory.FromSingleDigitInt(-1);
            }
            catch
            {
                errorWasThrown = true;
            }
            Assert.IsTrue(errorWasThrown);
        }
    }
}
