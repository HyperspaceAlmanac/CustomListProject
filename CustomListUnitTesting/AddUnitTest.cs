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
            CustomList<string> stringList = new CustomList<string>();
            // Act
            int expected = 1;

            stringList.Add("Value");
            int actual = stringList.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutIntIntoEmptyList_CapacityShouldEqualFour()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 4;

            intList.Add(1);
            int actual = intList.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutFourIntsIntoEmptyList_CapacityShouldEqualFour()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 4;

            for (int i = 0; i < 4; i++)
            {
                intList.Add(1);
            }
            int actual = intList.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutNineIntoEmptyList_CapacityShouldEqualSixTeen()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 16;

            for (int i = 0; i < 9; i++)
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
