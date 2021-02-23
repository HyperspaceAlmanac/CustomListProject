using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AdditionOperatorUnitTest
    {
        [TestMethod]
        public void AdditionOverload_EmptyListAndEmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // Act
            string expected = new CustomList<int>().ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_EmptyListAndEmptyList_CountShouldBeZero()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();

            // Act
            int expected = 0;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_EmptyListAndOneItem_ShouldEqualOneItemList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            right.Add(1);

            // Act
            CustomList<int> temp = new CustomList<int>();
            temp.Add(1);
            string expected = temp.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_EmptyListAndOneItem_CountShouldBeOne()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            right.Add(1);

            // Act
            int expected = 1;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_OneItemAndEmptyList_ShouldEqualOneItemList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            left.Add(1);
            CustomList<int> right = new CustomList<int>();

            // Act
            CustomList<int> temp = new CustomList<int>();
            temp.Add(1);
            string expected = temp.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_OneItemAndEmptyList_CountShouldBeOne()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            right.Add(1);

            // Act
            int expected = 1;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverload_OneItemAndOneItem_ShouldEqualTwoItemsList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            left.Add(1);
            CustomList<int> right = new CustomList<int>();
            left.Add(2);

            // Act
            CustomList<int> temp = new CustomList<int>();
            temp.Add(1);
            temp.Add(2);
            string expected = temp.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_OneItemAndOneItem_CountShouldBeTwo()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            left.Add(1);
            CustomList<int> right = new CustomList<int>();
            right.Add(2);

            // Act
            int expected = 2;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // Smaller Capacity (4) + Larger Capacity (8) should lead to capacity of 16
        public void AdditionOverload_FourItemsAndFiveItems_ShouldEqualNineItemsList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            CustomList<int> singleList = new CustomList<int>();
            for (int i = 0; i < 4; i++)
            {
                left.Add(i);
                right.Add(i + 4);
            }
            right.Add(8);
            for (int i = 0; i < 9; i++)
            {
                singleList.Add(i);
            }

            // Act
            string expected = singleList.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_FourItemsAndFiveItems_CapacityShouldBe16()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            for (int i = 0; i < 4; i++)
            {
                left.Add(i);
                right.Add(i + 4);
            }
            right.Add(8);

            // Act
            int expected = 16;
            int actual = (left + right).Capacity;

            // Assert
            Assert.AreEqual(expected, actual);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_FourItemsAndFiveItems_CountShouldBeNine()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            for (int i = 0; i < 4; i++)
            {
                left.Add(i);
                right.Add(i + 4);
            }
            right.Add(8);

            // Act
            int expected = 9;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // Larger Capacity (16) + Smaller Capacity (6) should lead to capacity of 16
        public void AdditionOverload_NineItemsAndSixItems_ShouldEqualFifteenItemsList()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            CustomList<int> singleList = new CustomList<int>();
            for (int i = 0; i < 9; i++)
            {
                left.Add(i);
                if (i < 6)
                {
                    right.Add(i + 9);
                }
            }
            for (int i = 0; i < 15; i++)
            {
                singleList.Add(i);
            }

            // Act
            string expected = singleList.ToString();
            string actual = (left + right).ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_NineItemsAndSixItems_CountShouldBeFifteen()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            for (int i = 0; i < 9; i++)
            {
                left.Add(i);
                if (i < 6)
                {
                    right.Add(i + 9);
                }
            }

            // Act
            int expected = 15;
            int actual = (left + right).Count;

            // Assert
            Assert.AreEqual(expected, actual);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdditionOverload_NineItemsAndSixItems_CapacityShouldStillBe16()
        {
            // Arrange
            CustomList<int> left = new CustomList<int>();
            CustomList<int> right = new CustomList<int>();
            for (int i = 0; i < 9; i++)
            {
                left.Add(i);
                if (i < 6)
                {
                    right.Add(i + 9);
                }
            }


            // Act
            int expected = 16;
            int actual = (left + right).Capacity;

            // Assert
            Assert.AreEqual(expected, actual);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
