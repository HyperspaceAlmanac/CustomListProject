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
    }
}
