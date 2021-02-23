using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ZipUnitTest
    {
        // Double capacity of first List until everything can fit
        [TestMethod]
        public void Zip_TwoEmptyLists_ShouldReturnNewEmptyList()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Zip_ThreeItem_EmptyList_ShouldReturnThreeItems()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Zip_ThreeItem_EmptyList_CapacityShouldBeFour()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Zip_ThreeItems_ThreeItems_ShouldReturnSixItems()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Zip_FiveItems_ThreeItems_ShouldReturnEightItems()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void Zip_FiveItems_ThreeItems_CapacityShouldBeEight()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Zip_FourItems_SixItems_ShouldReturnTenItems()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void Zip_FourItems_SixItems_CapacityShouldBeSixteen()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
