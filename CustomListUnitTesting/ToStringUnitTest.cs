using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ToStringUnitTest
    {
        [TestMethod]
        public void ToString_EmptyList_ShouldMatchEmptyBracketsString()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            // Act
            string expected = "[]";
            string actual = intList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_OneItemList_ShouldReturnItemToStringInBrackets()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int one = 1;

            // Act
            intList.Add(one);
            string expected = "[" +  one.ToString() + "]";
            string actual = intList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ThreeItemsList_ShouldReturnItemsToStringInBrackets()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;

            // Act
            intList.Add(one);
            intList.Add(two);
            intList.Add(three);
            string expected = $"[{one},{two},{three}]";
            string actual = intList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ThreeItemsList_RemoveAll_ShouldReturnJustBrackets()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;
            intList.Add(one);
            intList.Add(two);
            intList.Add(three);

            // Act
            intList.Remove(one);
            intList.Remove(two);
            intList.Remove(three);
            string expected = "[]";
            string actual = intList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThreeItemsList_AddAndThenRemoveValuesAtEnd_ShouldHaveSameToStringValues()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            intList.Add(one);
            intList.Add(two);
            intList.Add(three);
            string expected = intList.ToString();

            // Act
            intList.Add(four);
            intList.Remove(four);
            string actual = intList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
