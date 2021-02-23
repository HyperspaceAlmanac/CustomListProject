using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class SubtractionOperator
    {
        [TestMethod]
        public void SubtractOperator_EmptyListAndEmptyList_ShouldReturnNewEmptyList()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            CustomList<int> rightOperand = new CustomList<int>();
            // Act
            string expected = "[]";
            string actual = (leftOperand - rightOperand).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_EmptyListAndThreeItemsList_ShouldReturnLeftOperand()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            CustomList<int> rightOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                rightOperand.Add(i);
            }
            // Act
            string expected = leftOperand.ToString();
            string actual = (leftOperand - rightOperand).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_ThreeItemsListAndemptyList_ShouldReturnLeftOperand()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            // Act
            string expected = leftOperand.ToString();
            string actual = (leftOperand - rightOperand).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_EmptyListAndEmptyList_CapacityMatchesLeftOperand()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            CustomList<int> rightOperand = new CustomList<int>();
            // Act
            int expected = leftOperand.Capacity;
            int actual = (leftOperand - rightOperand).Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void SubtractOperator_ThreeItemsListAndemptyList_CapacityMatchesLeftOperand()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            // Act
            int expected = leftOperand.Capacity;
            int actual = (leftOperand - rightOperand).Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
