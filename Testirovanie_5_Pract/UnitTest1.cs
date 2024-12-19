using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testirovanie_5_Pract
{
    [TestClass]
    public class CollectionTests
    {
        private static List<int> collection1;
        private static List<int> collection2;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            collection1 = new List<int> { 1, 2, 3, 4, 5 };
            collection2 = new List<int> { 5, 4, 3, 2, 1 };
        }

        [TestMethod]
        public void CompareCollectionsInOrder()
        {
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(expected, collection1, "Коллекции не совпадают по порядку.");
        }

        [TestMethod]
        public void CompareCollectionsIgnoringOrder()
        {
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEquivalent(expected, collection2, "Коллекции не эквивалентны игнорированию порядка.");
        }

        [TestMethod]
        public void TestPercentageCalculationWithDelta()
        {
            double expected = 25.0;
            double actual = CalculatePercentage(25, 100);
            double delta = 0.01;
            Assert.AreEqual(expected, actual, delta, "Расчет процента неверен.");
        }

        private double CalculatePercentage(double part, double total)
        {
            if (total == 0)
                throw new DivideByZeroException("Общая сумма не может быть равна нулю.\r\n");

            return (part / total) * 100;
        }
    }
}