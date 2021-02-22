using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddUnitTest
    {
        [TestMethod]
        public void Add_PutIntIntoEmptyList_CountShouldEqualOne()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 1;

            intList.Add(1);
            int actual = intList.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutStringIntoEmptyList_CountShouldEqualOne()
        {
            // Arrange
            CustomList<string> intList = new CustomList<string>();
            // Act
            int expected = 1;

            intList.Add("Value");
            int actual = intList.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutIntIntoEmptyList_CapacityShouldEqualFive()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 5;

            intList.Add(1);
            int actual = intList.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutFiveIntsIntoEmptyList_CapacityShouldEqualTen()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 5;

            for (int i = 0; i < 5; i++)
            {
                intList.Add(1);
            }
            int actual = intList.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutNineteenIntsIntoEmptyList_CapacityShouldEqualTwenty()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 5;

            for (int i = 0; i < 19; i++)
            {
                intList.Add(1);
            }
            int actual = intList.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutFiveIntsIntoEmptyList_ValueShouldEqualIndexAtEachIndex()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 5;

            for (int i = 0; i < 5; i++)
            {
                intList.Add(i);
            }
            // Assert
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(intList[i], i);
            }
        }
    }
}
