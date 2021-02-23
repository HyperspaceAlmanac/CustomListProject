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
        [TestMethod]

        public void SubtractOperator_ThreeItemsListAndEmptyList_CapacityMatchesLeftOperand()
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
        [TestMethod]
        public void SubtractOperator_ThreeItemsListAndOneCommonValue_OneValueRemoved()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            rightOperand.Add(1);
            // Act
            int expected = leftOperand.Count - 1;
            int actual = (leftOperand - rightOperand).Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_ThreeItemsListAndOneCommonValue_ValuesShiftsDownCorrectly()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            rightOperand.Add(1);

            CustomList<int> zeroTwo = new CustomList<int>();
            zeroTwo.Add(0);
            zeroTwo.Add(2);
            // Act
            string expected = zeroTwo.ToString();
            string actual = (leftOperand - rightOperand).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_ThreeItemsListAndOneCommonValue_LeftOperandUnchanged()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            rightOperand.Add(1);
            // Act
            string expected = leftOperand.ToString();
            CustomList<int> throwAway = leftOperand - rightOperand;
            string actual = leftOperand.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_ThreeItemsListAndOneCommonValue_RightOperandUnchanged()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
            }
            CustomList<int> rightOperand = new CustomList<int>();
            rightOperand.Add(1);
            // Act
            string expected = rightOperand.ToString();
            CustomList<int> throwAway = leftOperand - rightOperand;
            string actual = rightOperand.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_SixItemsListAndTwoCommonValues_RemoveOnlyFirstInstance()
        {
            // Arrange
            CustomList<int> leftOperand = new CustomList<int>();
            CustomList<int> rightOperand = new CustomList<int>();
            CustomList<int> twoOneZero = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftOperand.Add(i);
                rightOperand.Add(i);
                twoOneZero.Add(2 - i);
            }
            leftOperand.Add(2);
            leftOperand.Add(1);
            leftOperand.Add(0);

            // Act
            string expected = twoOneZero.ToString();
            string actual = (leftOperand - rightOperand).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
