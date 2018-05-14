using System;
using System.Collections;
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
            int expectedCount = 6;
            //act
            c.Add(1);
            c.Add(2);
            c.Add(3);
            c.Add(4);
            c.Add(5);
            c.Add(6);
            int actualCount = c.Count;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void AddOperator_NewCountEqualsSum_()
        {
            int expectedResult = 6;
            CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> c2 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> c3 = new CustomList<int>();
            c3 = c1 + c2;
            Assert.AreEqual(expectedResult, c3.Count);
        }
        [TestMethod]
        public void AddOperator_TwoInstancesAreJoined_()
        {
           
            CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> c2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> c3 = new CustomList<int>();
            c3 = c1 + c2;
            Assert.AreEqual(5, c3[4]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddOperator_TwoInstancesAreJoined_IndexOutOfRange()
        {
            CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> c2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> c3 = new CustomList<int>();
            c3 = c1 + c2;
            int expectedOutOfRange = c3[6];
        }
        [TestMethod]
        public void AddOperator_FirstIndexOfSecondInstanceDoesNotOverLapFirstInstance_()
        {
            CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> c2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> c3 = new CustomList<int>();
            c3 = c1 + c2;
            Assert.AreNotEqual(c3[2], c2[0]);
        }
        [TestMethod]
        public void GetEnumerator_LengthEqualsCount_AreEqual()
        {
            int expectedResult = 3;
            int actualResult = 0;
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            foreach(int el in c)
            {
                actualResult++;
            }
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GetEnumerator_DoesNotIterateEntireCapactiy_ActualShouldNotEqualCapacity()
        {

            int collectionElements = 0;
            CustomList<int> c = new CustomList<int>() {1, 2, 3};
            int maxCapacity = c.Capacity;
            foreach (int el in c)
            {
                collectionElements++;
            }
            Assert.AreNotEqual(collectionElements, maxCapacity);
        }

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void MinusOperator_SecondInstanceGetsRemoved_()
        //{
        //    CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
        //    CustomList<int> c2 = new CustomList<int>() { 4, 5, 6 };
        //    CustomList<int> c3 = new CustomList<int>();
        //    c3 = c1 + c2;
        //    c3 = c1 - c2;
        //    int result = c3[3];
        //}

        //[TestMethod]
        //public void MinusOperator_CountEqualsFirstInstanceLength_()
        //{
        //    CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
        //    CustomList<int> c2 = new CustomList<int>() { 4, 5, 6 };
        //    CustomList<int> c3 = new CustomList<int>();
        //    c3 = c1 + c2;
        //    c3 = c1 - c2;
        //    Assert.AreEqual(c1.Count, c3.Count);
        //}

        //[TestMethod]
        //public void MinusOperator_ElementsOfSecondInstanceDoNotExistInResult_()
        //{
        //    CustomList<int> c1 = new CustomList<int>() { 1, 2, 3 };
        //    CustomList<int> c2 = new CustomList<int>() { 4 };
        //    CustomList<int> c3 = new CustomList<int>();
        //    c3 = c1 + c2;
        //    c3 = c1 - c2;
        //    Assert.AreNotEqual(4, c3[0]);
        //}

        [TestMethod]
        public void Remove_ElementGetsRemoved_()
        {
            //arrange
            int inputValue = 1;
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c.Remove(inputValue);
            //assert
            Assert.AreEqual(2, c.arr[0]);
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
            int actualResult = c.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_ArrayCountStaysTheSame_ShouldNotEqual()
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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_DoesNotShiftIfElementDoesNotExist_ArrayShouldShift()
        {
            //arrange
            int inputValue = 4;
            int[] expectedResult = {1, 2, 3 };
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c.Remove(inputValue);
            //assert
        }

        [TestMethod]
        public void ToString_ElementsAreTypeString()
        {
            //arrange
            CustomList<int> c = new CustomList<int>() { 1, 2, 3 };
            //act
            c[1].ToString();
            //assert
            Assert.AreEqual("Element 1: 2", c[1]);
        }

        [TestMethod]
        public void Zipper_CountChanges_c1LengthPlusc2LengthEqualsc3Length()
        {
            CustomList<int> c1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> c2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> c3 = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            c1.Zipper(c2);

            Assert.AreEqual(c3.Count, c1.Count);
        }
        //different lengths
        [TestMethod]
        public void Zipper_ElementsAlternate_()
        {
            CustomList<int> c1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> c2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> c3 = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            c1.Zipper(c2);

            Assert.AreEqual(c1, c3);
        }
        [TestMethod]
        public void Zipper_SecondObjectStaysTheSame_()
        {
            CustomList<int> c1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> c2 = new CustomList<int>() { 2, 4, 6 };

            c1.Zipper(c2);

            Assert.AreEqual(2, c2[0]);
        }

    }
}
