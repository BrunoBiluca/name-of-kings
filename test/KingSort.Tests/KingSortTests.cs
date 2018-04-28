using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KingSort.Sorters;

namespace KingSort.Tests {
    [TestClass]
    public class KingSortTests {

        [TestMethod]
        public void EmptyArray() {
            String[] test = { };
            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void SimplesNameArray() {
            String[] test = { "Louis IX", "Louis VIII" };

            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(test[1], result[0]);
            Assert.AreEqual(test[0], result[1]);
        }

        [TestMethod]
        public void SimplesNameArray2() {
            String[] test = { "Louis IX", "Philippe II" };


            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(test[0], result[0]);
            Assert.AreEqual(test[1], result[1]);
        }


        [TestMethod]
        public void SimplesNameArray3() {
            String[] test = { "Richard III", "Richard I", "Richard II" };


            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(test[1], result[0]);
            Assert.AreEqual(test[2], result[1]);
            Assert.AreEqual(test[0], result[2]);
        }


        [TestMethod]
        public void SimplesNameArray4() {
            String[] test = { "John X", "John I", "John L", "John V" };


            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(test[1], result[0]);
            Assert.AreEqual(test[3], result[1]);
            Assert.AreEqual(test[0], result[2]);
            Assert.AreEqual(test[2], result[3]);
        }
        [TestMethod]
        public void SimplesNameArray5() {
            String[] test = {
                "Philippe VI",
                "Jean II",
                "Charles V",
                "Charles VI",
                "Charles VII",
                "Louis XI"
            };


            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(6, result.Length);
            Assert.AreEqual(test[2], result[0]);
            Assert.AreEqual(test[3], result[1]);
            Assert.AreEqual(test[4], result[2]);
            Assert.AreEqual(test[1], result[3]);
            Assert.AreEqual(test[5], result[4]);
            Assert.AreEqual(test[0], result[5]);
        }


        [TestMethod]
        public void LexicographicallyNameArray() {
            String[] test = { "Philippe II", "Philip II" };


            var kingSort = new Sorters.KingSort();
            var result = kingSort.GetSortedList(test);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(test[1], result[0]);
            Assert.AreEqual(test[0], result[1]);
        }

        [TestMethod]
        public void GetRomanNumberTest() {
            var kingSort = new King("Louis VIII");

            Assert.AreEqual("VIII", kingSort.Number);
        }

        [TestMethod]
        public void GetRomanNumberStringWithNoNumberTest() {
            var kingSort = new King("Louis Costa");

            Assert.AreEqual(0, kingSort.Number.Length);
            Assert.AreEqual("", kingSort.Number);
        }

        [TestMethod]
        public void GetKingNameWithNumberTest() {
            var kingSort = new King("Louis Costa VIII");

            Assert.AreEqual("Louis Costa", kingSort.Name);
        }

        [TestMethod]
        public void GetKingNameWithoutNumber() {
            var kingSort = new King("Louis Costa");

            Assert.AreEqual("Louis Costa", kingSort.Name);
        }

        [TestMethod]
        public void GetNumberValueWithNumberTest() {
            var kingSort = new King("Louis Costa VIII");

            Assert.AreEqual(8, kingSort.NumberValue);
        }

        [TestMethod]
        public void GetNumberValueWithNumberStraightTest() {
            var kingSort = new King("Louis Costa VIII");

            Assert.AreEqual(8, kingSort.NumberValue);
        }

        [TestMethod]
        public void GetNumberValueWithNumberReverseTest() {
            var kingSort = new King("Louis Costa IX");

            Assert.AreEqual(9, kingSort.NumberValue);
        }

        [TestMethod]
        public void GetNumberValueWithNumberStraightAndReverseTest() {
            var kingSort = new King("Louis Costa XLVII");

            Assert.AreEqual(47, kingSort.NumberValue);
        }

        [TestMethod]
        public void GetNumberValueWithoutNumber() {
            var kingSort = new King("Louis Costa");

            Assert.AreEqual(0, kingSort.NumberValue);
        }
    }
}
