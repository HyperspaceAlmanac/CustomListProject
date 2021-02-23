using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class CapacityProperyUnitTest
    {
        [TestMethod]
        public void Capacity_Emptylist_CanSetCapacityToTen()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            cList.Capacity = 10;
            int expected = 10;
            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_CanSetCapacityToTen()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            cList.Capacity = 10;
            int expected = 10;
            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToTen_ItemsRemainSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            string expected = cList.ToString();
            cList.Capacity = 10;
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToFour_CapacityShouldNotChange()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            cList.Capacity = 4;
            int expected = 8;
            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToFour_ItemsShouldNotChange()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            string expected = cList.ToString();
            cList.Capacity = 4;
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToFour_CountShouldNotChange()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            int expected = cList.Count;
            cList.Capacity = 4;
            
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToTen_CountShouldNotChange()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            int expected = cList.Count;
            cList.Capacity = 10;

            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsList_SetCapacityToNegativeValue_CapacityShouldNotChange()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
            }

            // Act
            int expected = cList.Capacity;
            cList.Capacity = -10;

            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Plus Operator Capacity tests
        // Without Manually setting Capacity
        [TestMethod]
        public void Capacity_EmptyListAndEmptyList_CapacityShouldStillBeZero()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 0;
            int actual = newList.Capacity;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_EmptyListAndFiveItems_CapacityShouldBeEight()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                rightList.Add(i);
            }

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 8;
            int actual = newList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Capacity_FiveItemsAndEmptyList_CapacityShouldBeEight()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                leftList.Add(i);
            }

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 8;
            int actual = newList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsAndThreeItemsList_CapacityShouldStillBeEight()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                leftList.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                rightList.Add(i);
            }

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 8;
            int actual = newList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FiveItemsAndFourItemsList_CapacityShouldStillBeSixteen()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                leftList.Add(i);
            }
            for (int i = 0; i < 4; i++)
            {
                rightList.Add(i);
            }

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 8;
            int actual = newList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_FourItemsAndFiveItemsList_CapacityShouldStillBeSixteen()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 4; i++)
            {
                leftList.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                rightList.Add(i);
            }

            // Act
            CustomList<int> newList = leftList + rightList;
            int expected = 8;
            int actual = newList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
