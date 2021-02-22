using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class BasicSanityUnitTests
    {
        [TestMethod]
        public void Count_AfterIntGenericInstantiation_ShouldBeZero()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            int expected = 0;
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_AfterStringGenericInstantiation_ShouldBeZero()
        {
            // Arrange
            CustomList<string> cList = new CustomList<string>();

            // Act
            int expected = 0;
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Capacity_AfterIntGenericInstantiationc_ShouldBeFive()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            int expected = 5;
            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_AfterObjectGenericInstantiation_ShouldBeZero()
        {
            // Arrange
            CustomList<Object> cList = new CustomList<Object>();

            // Act
            int expected = 0;
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
