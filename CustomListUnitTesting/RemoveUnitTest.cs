using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveUnitTest
    {
        [TestMethod]
        public void Remove_EmptyList_ShouldReturnFalse()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            // Act
            bool expected = false;
            bool actual = intList.Remove(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FourIntList_ItemNotInThere_ShouldReturnFalse()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            // Act
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            bool expected = false;
            bool actual = intList.Remove(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FourIntList_ItemNotInThere_CountShouldNotChange()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            // Act
            int expected = 4;
            intList.Remove(1);
            int actual = intList.Count;
            

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
