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
        public void FromSingleDigit_Should_Return_Value_For_Each_Number_1_Through_9()
        {
            var listOfEnums = new List<DigitDisplayPattern>();

            for(int i=0;i<10;i++)
            {
                listOfEnums.Add(DigitDisplayPatternFactory.FromSingleDigit(i));
            }

            Assert.AreEqual(10, listOfEnums.Count);
            Assert.IsFalse(listOfEnums.Contains(0));
        }

        [TestMethod]
        public void FromSingleDigit_Should_Throw_Exception_Given_10()
        {
            bool errorWasThrown = false;
            try
            {
                DigitDisplayPattern digit = DigitDisplayPatternFactory.FromSingleDigit(10);
            }
            catch
            {
                errorWasThrown = true;
            }
            Assert.IsTrue(errorWasThrown);
        }

        [TestMethod]
        public void FromSingleDigit_Should_Throw_Exception_Given_Minus1()
        {
            bool errorWasThrown = false;
            try
            {
                DigitDisplayPattern digit = DigitDisplayPatternFactory.FromSingleDigit(-1);
            }
            catch
            {
                errorWasThrown = true;
            }
            Assert.IsTrue(errorWasThrown);
        }

        [TestMethod]
        public void CreateEnumerable_Should_Return_Single_Item_List_Given_Single_Digit_Int()
        {
            IEnumerable<DigitDisplayPattern> digits = DigitDisplayPatternFactory.CreateEnumerable(5);

            Assert.AreEqual(1, digits.Count());
        }

        [TestMethod]
        public void CreateEnumerable_Should_Return_Zero_Given_Zero()
        {
            IEnumerable<DigitDisplayPattern> digits = DigitDisplayPatternFactory.CreateEnumerable(0);

            Assert.AreEqual(1, digits.Count());
            Assert.AreEqual(DigitDisplayPatternFactory.Zero, digits.First());
        }

        [TestMethod]
        public void CreateEnumerable_Should_Return_OneZero_Given_10()
        {
            var digits = DigitDisplayPatternFactory.CreateEnumerable(10).ToArray();

            Assert.AreEqual(DigitDisplayPatternFactory.One, digits[0]);
            Assert.AreEqual(DigitDisplayPatternFactory.Zero, digits[1]);
        }

        [TestMethod]
        public void CreateEnumerable_Should_Return_MinusOne_Given_Minus1()
        {
            var digits = DigitDisplayPatternFactory.CreateEnumerable(-1).ToArray();

            Assert.AreEqual(DigitDisplayPatternFactory.Minus, digits[0]);
            Assert.AreEqual(DigitDisplayPatternFactory.One, digits[1]);
        }

        [TestMethod]
        public void CreateEnumerable_Should_Return_ThreeTwoSevenSixSeven_Given_IntMax()
        {
            var digits = DigitDisplayPatternFactory.CreateEnumerable(Int16.MaxValue).ToArray();

            Assert.AreEqual(DigitDisplayPatternFactory.Three, digits[0]);
            Assert.AreEqual(DigitDisplayPatternFactory.Two, digits[1]);
            Assert.AreEqual(DigitDisplayPatternFactory.Seven, digits[2]);
            Assert.AreEqual(DigitDisplayPatternFactory.Six, digits[3]);
            Assert.AreEqual(DigitDisplayPatternFactory.Seven, digits[4]);
        }


        [TestMethod]
        public void CreateEnumerable_Should_Return_MinusThreeTwoSevenSixEight_Given_IntMin()
        {
            var digits = DigitDisplayPatternFactory.CreateEnumerable(Int16.MinValue).ToArray();

            Assert.AreEqual(DigitDisplayPatternFactory.Minus, digits[0]);
            Assert.AreEqual(DigitDisplayPatternFactory.Three, digits[1]);
            Assert.AreEqual(DigitDisplayPatternFactory.Two, digits[2]);
            Assert.AreEqual(DigitDisplayPatternFactory.Seven, digits[3]);
            Assert.AreEqual(DigitDisplayPatternFactory.Six, digits[4]);
            Assert.AreEqual(DigitDisplayPatternFactory.Eight, digits[5]);
        }
    }
}
