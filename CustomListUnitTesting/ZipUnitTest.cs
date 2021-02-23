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
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            // Act
            string expected = "[]";
            string actual = leftList.Zip(rightList).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ThreeItemsLeft_EmptyListRight_ShouldMatchThreeItemsLeftListValues()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            CustomList<int> zeroOneTwo = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                zeroOneTwo.Add(i);
                leftList.Add(i);
            }

            // Act
            string expected = zeroOneTwo.ToString();
            string actual = leftList.Zip(rightList).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_EmptyListLeft_ThreeItemsRight_ShouldReturnRightListValues()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            CustomList<int> zeroOneTwo = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                zeroOneTwo.Add(i);
                rightList.Add(i);
            }

            // Act
            string expected = zeroOneTwo.ToString();
            string actual = leftList.Zip(rightList).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ThreeItem_EmptyList_CapacityShouldBeFour()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            for (int i = 0; i < 3; i++)
            {
                leftList.Add(i);
            }

            // Act
            int expected = 4;
            int actual = leftList.Zip(rightList).Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ThreeItems_ThreeItems_ShouldReturnSixInterleavedItems()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 6; i += 2)
            {
                leftList.Add(i);
                rightList.Add(i + 1);
            }
            CustomList<int> zeroToFive = new CustomList<int>();
            for (int i = 0; i < 6; i++)
            {
                zeroToFive.Add(i);
            }
            // Act
            string expected = zeroToFive.ToString();
            string actual = leftList.Zip(rightList).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_FiveItems_ThreeItems_ShouldReturnEightInterleavedItems()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 3; i++)
            {
                leftList.Add(i * 2);
                rightList.Add(i * 2 + 1);
            }
            leftList.Add(6);
            leftList.Add(7);
            CustomList<int> expectedList = new CustomList<int>();
            for (int i = 0; i < 8; i++)
            {
                expectedList.Add(i);
            }

            // Act
            string expected = expectedList.ToString();
            string actual = leftList.Zip(rightList).ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_FiveItems_ThreeItems_CapacityShouldBeEight()
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
            int expected = 8;
            int actual = leftList.Zip(rightList).Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_FourItems_SixItems_ShouldReturnTenInterleavedValues()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();
            for (int i = 0; i < 4; i++)
            {
                leftList.Add(i * 2);
                rightList.Add(i * 2 + 1);
            }
            rightList.Add(8);
            rightList.Add(9);


            CustomList<int> expectedList = new CustomList<int>();
            for (int i = 0; i < 10; i++)
            {
                expectedList.Add(i);
            }

            // Act
            string expected = expectedList.ToString();
            string actual = leftList.Zip(rightList).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_FourItems_SixItems_LeftListShouldRemainTheSame()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            for (int i = 0; i < 4; i++)
            {
                leftList.Add(i * 2);
                rightList.Add(i * 2 + 1);
            }
            rightList.Add(8);
            rightList.Add(9);

            // Act
            string expected = leftList.ToString();
            CustomList<int> temp = leftList.Zip(rightList);
            string actual = leftList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_FourItems_SixItems_RightListShouldRemainTheSame()
        {
            /// Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            for (int i = 0; i < 4; i++)
            {
                leftList.Add(i * 2);
                rightList.Add(i * 2 + 1);
            }
            rightList.Add(8);
            rightList.Add(9);

            // Act
            string expected = rightList.ToString();
            CustomList<int> temp = leftList.Zip(rightList);
            string actual = rightList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_FourItems_SixItems_CapacityShouldBeSixteen()
        {
            // Arrange
            CustomList<int> leftList = new CustomList<int>();
            CustomList<int> rightList = new CustomList<int>();

            for (int i = 0; i < 4; i++)
            {
                leftList.Add(i * 2);
                rightList.Add(i * 2 + 1);
            }
            rightList.Add(8);
            rightList.Add(9);

            // Act
            int expected = 16;
            int actual = leftList.Zip(rightList).Count;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
