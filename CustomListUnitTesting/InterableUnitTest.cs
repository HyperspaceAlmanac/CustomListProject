using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System.Collections;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class InterableUnitTest
    {
        [TestMethod]
        public void Iterable_EmptyList_ShouldNotIterate()
        {
            // Arrange
            CustomList<int> emptyList = new CustomList<int>();

            // Act

            // Assert
            foreach (int intVal in emptyList)
            {
                Assert.Fail("Should not do anything for empty list");
            }
        }

        [TestMethod]
        public void Iterable_OneItemList_ShouldReturnOneValue()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(99);

            // Act
            int expected = 99;

            // Assert
            foreach (int intVal in cList)
            {
                Assert.AreEqual(expected, intVal);
            }
        }

        [TestMethod]
        public void Iterable_ThreeItemList_ShouldReturnThreeValues()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(101);
            cList.Add(7);
            cList.Add(1);

            // Act
            int[] expected = new int[] { 101, 7, 1 };
            int counter = 0;

            // Assert
            foreach (int intVal in cList)
            {
                Assert.AreEqual(expected[counter], intVal);
                counter += 1;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Iterable_ThreeItemList_ShouldThrowExceptionIfValueChanges()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(101);
            cList.Add(7);
            cList.Add(1);

            // Act
            int[] expected = new int[] { 101, 7, 1 };
            int counter = 0;

            // Assert
            foreach (int intVal in cList)
            {
                if (counter == 1)
                {
                    cList[2] = 3;
                }
                Assert.AreEqual(expected[counter], intVal);
                counter += 1;
            }
        }
        [TestMethod]
        public void TransactionID_NewEmptyList_ShouldBeZero()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            int expected = 0;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransactionID_AddOneItemToList_ShouldBeOne()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            int expected = 1;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransactionID_AddTwoItemToListRemoveOneSuccess_ShouldBeThree()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            cList.Add(2);
            cList.Remove(1);
            int expected = 3;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_AddTwoItemToListUnableToRemoveValue_ShouldBeTwo()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            cList.Add(2);
            cList.Remove(100);
            int expected = 2;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransactionID_AddTwoItemToList_IndexerGetValue_ShouldStillBeTtwo()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            cList.Add(2);
            int temp = cList[1];
            int expected = 2;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_AddTwoItemToList_IndexerUpdatesValue_ShouldBeThree()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            cList.Add(2);
            cList[1] = 3;
            int expected = 3;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_AddTwoItemToList_IndexerUpdatesSameValue_ShouldBeThree()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Add(1);
            cList.Add(2);
            cList[1] = 2;
            int expected = 3;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransactionID_AddTwoItemToList_UseAddOperator_ShouldStillBeTwo()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            CustomList<int> other = new CustomList<int>();
            
            cList.Add(1);
            cList.Add(2);

            other.Add(1);
            other.Add(2);
            other.Add(3);

            // Act
            CustomList<int> temp = cList + other;

            int expected = 2;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_AddTwoItemToList_UseSubtractOperator_ShouldStillBeTwo()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            CustomList<int> other = new CustomList<int>();

            cList.Add(1);
            cList.Add(2);

            other.Add(1);
            other.Add(2);
            other.Add(3);

            // Act
            CustomList<int> temp = cList - other;

            int expected = 2;
            int actual = cList.TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TransactionID_FiveItemsPlusFourItems_ShouldBeNine()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // 8 operations
            left.Add(1);
            left.Add(2);
            left.Add(3);
            left.Add(4);
            left.Add(5);
            left.Remove(5);
            left.Add(5);
            left[4] = 5;

            //7 operations
            right.Add(1);
            right.Add(2);
            right.Add(3);
            right.Add(4);
            right.Add(5);
            right[4] = 0;
            right[4] = 5;

            // Act
            int expected = 9;
            int actual = (left + right).TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_FiveItemsSubtractThree_NoneRemoved_ShouldBeFive()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // 8 operations
            left.Add(1);
            left.Add(2);
            left.Add(3);
            left.Add(4);
            left.Add(5);
            left.Remove(5);
            left.Add(5);
            left[4] = 5;

            //6 operations
            right.Add(1);
            right.Add(2);
            right.Add(3);
            right[0] = -1;
            right[1] = -2;
            right[2] = -3;

            // Act
            int expected = 5;
            int actual = (left - right).TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TransactionID_FiveItemsSubtractThree_TwoRemoved_ShouldBeSeven()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // 8 operations
            left.Add(1);
            left.Add(2);
            left.Add(3);
            left.Add(4);
            left.Add(5);
            left.Remove(5);
            left.Add(5);
            left[4] = 5;

            //6 operations
            right.Add(1);
            right.Add(2);
            right.Add(3);
            right[2] = -5;

            // Act
            int expected = 7;
            int actual = (left - right).TransactionID;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
