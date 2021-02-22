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
            bool expected = false;
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

    }
}
