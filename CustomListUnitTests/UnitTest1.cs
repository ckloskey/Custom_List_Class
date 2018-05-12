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
            int actualCount = c.Count;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Add_AddItemsToArrayCheckSpecificIndex_()
        {
            //arrange
            CustomList<int> c = new CustomList<int>();
            int expectedValue = 2;
            //act
            c.Add(1);
            c.Add(2);
            c.Add(3);
            //assert
            Assert.AreEqual(expectedValue, c.arr[1]);
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
            Assert.AreEqual(inputValue, c.arr[0]);
        }

        [TestMethod]
        public void Add_AddMultipleItemsAtOnce_()
        {
            //arrange
            CustomList<int> c = new CustomList<int>();
            int expectedCount = 5;
            //act
            c.Add(1);
            c.Add(2);
            c.Add(3);
            c.Add(4);
            c.Add(5);
            int actualCount = c.Count;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Remove_ElementGetsRemoved_()
        {
            //arrange
            int inputValue = 1;
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c.Remove(inputValue);
            //assert
            Assert.AreEqual(2, c.arr);
        }

        [TestMethod]
        public void Remove_ArrayCountDecreases_()
        {
            //arrange
            int inputValue = 1;
            int expectedResult = 2;
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 }; 
            //act
            c.Remove(inputValue);
            int actualResult = c.arr.Length;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_ArrayCountStaysTheSame_()
        {
            //arrange
            int inputValue = 1;
            int expectedResult = 1;
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c.Remove(inputValue);
            int actualResult = c.Capacity;
            //assert
            Assert.AreNotEqual(expectedResult, c.arr[0]);
        }

        [TestMethod]
        public void Remove_DoesNotShiftIfElementDoesNotExist_()
        {
            //arrange
            int inputValue = 4;
            int[] expectedResult = {1, 2, 3 };
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c.Remove(inputValue);
            //assert
            Assert.AreEqual(expectedResult, c.arr);
        }


    }
}
