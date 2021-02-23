using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AdditionOperatorUnitTest
    {
        [TestMethod]
        public void AdditionOverload_EmptyListAndEmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // Act
            string expected = new CustomList<int>().ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_EmptyListAndOneItem_ShouldReturnOneItem()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            right.Add(1);

            // Act
            CustomList<int> temp = new CustomList<int>();
            temp.Add(1);
            string expected = temp.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_OneItemAndEmptyList_ShouldReturnOneItem()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            left.Add(1);
            CustomList<int> right = new CustomList<int>();

            // Act
            CustomList<int> temp = new CustomList<int>();
            temp.Add(1);
            string expected = temp.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
