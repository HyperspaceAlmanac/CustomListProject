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

    }
}
