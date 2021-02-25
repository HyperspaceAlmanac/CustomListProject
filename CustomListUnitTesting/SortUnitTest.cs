using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class SortUnitTest
    {
        [TestMethod]
        public void Sort_EmptyList_ShouldStayTheSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            CustomList<int> empty = new CustomList<int>();

            // Act
            string expected = empty.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_SingleItem_ShouldStayTheSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(0);
            CustomList<int> oneItem = new CustomList<int>();
            oneItem.Add(0);

            // Act
            string expected = oneItem.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_TwoIntSmallerBigger_ShouldStatyTheSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(0);
            cList.Add(5);
            CustomList<int> zeroFive= new CustomList<int>();
            zeroFive.Add(0);
            zeroFive.Add(5);

            // Act
            string expected = zeroFive.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sort_TwoIntBiggerSmaller_ShouldSwapAround()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(5);
            cList.Add(0);
            CustomList<int> zeroFive = new CustomList<int>();
            zeroFive.Add(0);
            zeroFive.Add(5);

            // Act
            string expected = zeroFive.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_FiveAscendingOrder_ShouldBeSorted()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            CustomList<int> zeroToFour = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                cList.Add(i);
                zeroToFour.Add(i);
            }

            // Act
            string expected = zeroToFour.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_FiveAscendingTwoDuplicate_ShouldBeSorted()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            CustomList<int> zeroToFour = new CustomList<int>();
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    cList.Add(1);
                    zeroToFour.Add(1);
                }
                else
                {
                    cList.Add(4 - i);
                    zeroToFour.Add(i);
                }
            }

            // Act
            string expected = zeroToFour.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_TenDescendingTwoDuplicate_ShouldBeSorted()
        {
            // Arrange
            CustomList<int> tenSortedValues = new CustomList<int>();
            tenSortedValues.Add(5);
            tenSortedValues.Add(11);
            tenSortedValues.Add(12);
            tenSortedValues.Add(25);
            tenSortedValues.Add(35);
            tenSortedValues.Add(35);
            tenSortedValues.Add(50);
            tenSortedValues.Add(51);
            tenSortedValues.Add(77);
            tenSortedValues.Add(99);
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 10; i++)
            {
                cList.Add(tenSortedValues[9 - i]);
            }

            // Act
            string expected = tenSortedValues.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_FiveValuesUnsorted_ShouldBeSorted()
        {
            // Arrange
            CustomList<int> fiveSortedValues = new CustomList<int>();
            fiveSortedValues.Add(5);
            fiveSortedValues.Add(11);
            fiveSortedValues.Add(12);
            fiveSortedValues.Add(25);
            fiveSortedValues.Add(30);
            CustomList<int> cList = new CustomList<int>();
            cList.Add(fiveSortedValues[3]);
            cList.Add(fiveSortedValues[1]);
            cList.Add(fiveSortedValues[0]);
            cList.Add(fiveSortedValues[4]);
            cList.Add(fiveSortedValues[2]);

            // Act
            string expected = fiveSortedValues.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_FiveValuesWithNegatives_ShouldBeSorted()
        {
            // Arrange
            CustomList<int> fiveSortedValues = new CustomList<int>();
            fiveSortedValues.Add(-22);
            fiveSortedValues.Add(-7);
            fiveSortedValues.Add(22);
            fiveSortedValues.Add(25);
            fiveSortedValues.Add(50);
            CustomList<int> cList = new CustomList<int>();
            cList.Add(fiveSortedValues[3]);
            cList.Add(fiveSortedValues[1]);
            cList.Add(fiveSortedValues[0]);
            cList.Add(fiveSortedValues[4]);
            cList.Add(fiveSortedValues[2]);

            // Act
            string expected = fiveSortedValues.ToString();
            cList.Sort();
            string actual = cList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_FiveValuesWithNegatives_CountShouldStayTheSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(22);
            cList.Add(-7);
            cList.Add(99);
            cList.Add(1);
            cList.Add(0);

            // Act
            int expected = 5;
            cList.Sort();
            int actual = cList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sort_FiveValuesWithNegatives_CapacityShouldStayTheSame()
        {
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            cList.Add(22);
            cList.Add(-7);
            cList.Add(99);
            cList.Add(1);
            cList.Add(0);

            // Act
            int expected = 8;
            cList.Sort();
            int actual = cList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_TwentyRandomValues_EachValueShouldBeBiggerThanOneOnLeft()
        {
            Random rand = new Random(99); // Give spcific seed
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 20; i++)
            {
                cList.Add(rand.Next(-100, 100));
            }

            // Act
            cList.Sort();

            // Assert
            for (int i = 1; i < cList.Count; i++)
            {
                Assert.IsTrue(cList[i] >= cList[i - 1]);
            }
        }
        [TestMethod]
        public void Sort_HundredRandomValues_EachValueShouldBeBiggerThanOneOnLeft()
        {
            Random rand = new Random(99); // Give spcific seed
            // Arrange
            CustomList<int> cList = new CustomList<int>();
            for (int i = 0; i < 100; i++)
            {
                cList.Add(rand.Next(-1000, 1000));
            }

            // Act
            cList.Sort();

            // Assert
            for (int i = 1; i < cList.Count; i++)
            {
                Assert.IsTrue(cList[i] >= cList[i - 1]);
            }
        }

    }
}
