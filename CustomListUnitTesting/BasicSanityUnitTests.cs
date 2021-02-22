using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class BasicSanityUnitTests
    {
        [TestMethod]
        public void Constructor_CreateIntGeneric_CountStartsAtZero()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();

            // Act
            int expected = 0;
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
