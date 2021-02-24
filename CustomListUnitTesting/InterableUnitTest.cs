using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
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
    }
}
