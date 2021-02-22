﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListImplementation;
using System;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddUnitTest
    {
        [TestMethod]
        public void Add_PutIntIntoEmptyList_CountShouldEqualOne()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            // Act
            int expected = 1;

            intList.Add(1);
            int actual = intList.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PutStringIntoEmptyList_CountShouldEqualOne()
        {
            // Arrange
            CustomList<string> intList = new CustomList<string>();
            // Act
            int expected = 1;

            intList.Add("Value");
            int actual = intList.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}