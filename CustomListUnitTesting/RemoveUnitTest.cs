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
        [TestMethod]
        public void Remove_FourIntList_OneMatch_ShouldReturnTrue()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            // Act
            bool expected = true;
            bool actual = intList.Remove(1);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FourIntList_OneMatch_CountShouldDecreaseByOne()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            // Act
            int expected = intList.Count - 1;
            intList.Remove(1);
            int actual = intList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FourIntList_OneMatchAtBeginning_OtherThreeValuesRemainsSame()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(100);
            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            // Act
            intList.Remove(100);

            // Assert
            for (int i = 0; i < intList.Count; i++)
            {
                Assert.AreEqual(i, intList[i]);
            }
        }
        [TestMethod]
        public void Remove_FourIntList_TwoMatch_CountShouldDecreaseByOne()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(1);
            intList.Add(1);
            intList.Add(3);
            intList.Add(4);
            // Act
            int expected = intList.Count - 1;
            intList.Remove(1);
            int actual = intList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FourIntList_OneMatchInMiddle_OtherValuesShouldRemainSame()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(0);
            intList.Add(100);
            intList.Add(1);
            intList.Add(2);
            
            // Act
            intList.Remove(100);

            // Assert
            // Assert
            for (int i = 0; i < intList.Count; i++)
            {
                Assert.AreEqual(i, intList[i]);
            }
        }


        // Batch 2
        [TestMethod]
        public void Remove_FourIntList_RemoveAllValues_NextRemoveShouldReturnFalse()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            // Act
            intList.Remove(0);
            intList.Remove(1);
            intList.Remove(2);
            intList.Remove(3);
            bool expected = false;
            bool actual = intList.Remove(0);

            // Assert

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Part 2 of remove 1 with 2 matches. Check if other value that matched shfited down by 1
        [TestMethod]
        public void Remove_FourIntList_TwoMatch_CountShouldDecreaseByOne()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();

            int matching = 0;
            int other = 1;
            intList.Add(matching);
            intList.Add(matching);
            intList.Add(other);
            intList.Add(other);
            // Act
            int expected = matching;
            intList.Remove(matching);
            int actual = intList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
