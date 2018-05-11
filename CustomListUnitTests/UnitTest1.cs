using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Add_AddItemToListCountIsOne_InputEqualsActual()
        {   
            //arrange
            CustomList<int> c = new CustomList<int>();
            int inputValue = 5;
            int expectedCount = 1;
            //act
            c.Add(inputValue);
            int actualCount = c.Capacity;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Add_AddItemsToArrayCheckSpecificIndex_()
        {
            //arrange
            CustomList<int> c = new CustomList<int>();
            int actualValue = 2;
            //act
            c.Add(1);
            c.Add(2);
            c.Add(3);
            //assert
            Assert.AreEqual(c.Arr[1], actualValue);
        }

        [TestMethod]
        public void Add_CheckItemInList_()
        {
            //arrange
            CustomList<int> c = new CustomList<int>();
            int inputValue = 5;
            //act
            c.Add(inputValue);

            //assert
            Assert.AreEqual(inputValue, c.Arr[0]);
        }

        [TestMethod]
        public void Add_AddMultipleItemsAtOnce_()
        {
            //arrange
            CustomList<int> c = new CustomList<int>();
            int expectedCount = 6;
            //act
            c.Add(1);
            c.Add(2);
            c.Add(3);
            c.Add(4);
            c.Add(5);
            c.Add(6);
            int actualCount = c.Capacity;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
