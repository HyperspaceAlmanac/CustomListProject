using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class IndexerUnitTests
    {

        // Correct indexing already covered by Add_PutFiveIntsIntoEmptyList_ValueShouldEqualIndexAtEachIndex

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_EmptyList_AccessIndexNegativeOneShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act

            // Assert
            int result = intList[-1];
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_EmptyList_AccessIndexZeroShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act

            // Assert
            int result = intList[0];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_EmptyList_AccessIndexOneShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act

            // Assert
            int result = intList[1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_FourItemsInList_AccessNegativeIndexShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            for (int i = 0; i < 4; i++)
            {
                intList.Add(i);
            }
            // Assert
            int result = intList[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_FourItemsInList_AccessIndexFourShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            for (int i = 0; i < 4; i++)
            {
                intList.Add(i);
            }

            // Assert
            int result = intList[4];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_SevenItemsInList_AccessIndexSevenShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            for (int i = 0; i < 7; i++)
            {
                intList.Add(i);
            }

            // Assert
            int result = intList[7];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_SevenItemsInList_AccessIndexNineShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            for (int i = 0; i < 7; i++)
            {
                intList.Add(i);
            }

            // Assert
            int result = intList[9];
        }
        // Set cases

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_NoItemsInList_SetIndexZeroShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act

            // Assert
            intList[0] = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_NoItemsInList_SetIndexAtNegativeOneShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act

            // Assert
            intList[-1] = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TwoItemsInList_SetIndexAtNegativeOneShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            intList.Add(0);
            intList.Add(0);

            // Assert
            intList[-1] = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TwoItemsInList_SetIndexAtIndexTwoShouldThrowException()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            intList.Add(0);
            intList.Add(0);

            // Assert
            intList[2] = 0;
        }

        // Set, and then Get
        [TestMethod]
        public void Indexer_FourItemsInList_SetAndGetIndexOneShouldMatch()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int original = 0;
            for (int i = 0; i < 4; i++)
            {
                intList.Add(original);
            }
            // Act
            intList[1] = 100;
            int expected = 100;
            int actual = intList[1];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        //
        [TestMethod]
        public void Indexer_FourItemsInListSetIndexAtThree_IndexZeroToTwoShouldNotChange()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            int original = 0;
            for (int i = 0; i < 4; i++)
            {
                intList.Add(original);
            }
            // Act
            intList[3] = 100;
            // Assert
            for (int i = 0; i < 3; i++) {
                Assert.AreEqual(original, intList[i]);
            }
        }
    }
}
