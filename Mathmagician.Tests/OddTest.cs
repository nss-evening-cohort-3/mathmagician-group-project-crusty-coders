using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void OddEnsureICanCreateAnInstance()//of a class
        {
            //Arrange
            //Act - we're writing code that doesn't exist yet
            Odd my_odd = new Odd(); //what I want to be ABLE to do

            //Assert
            Assert.IsNotNull(my_odd);
        }
        //Act
        //create a test checking to make sure we can create a list starting at zero
        [TestMethod]
        public void TestOddGeneratingList()
        {
            //Arrange
            Odd TestOddList1 = new Odd();
            //Act
            List<int> result = TestOddList1.GenerateList(2);
            //Assert
            List<int> expectedList = new List<int>() { 1, 3 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList2()
        {
            //Arrange
            Odd TestOddList2 = new Odd();
            //Act
            List<int> result = TestOddList2.GenerateList(6);
            //Assert
            List<int> expectedList = new List<int>() { 1, 3, 5, 7, 9, 11 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList3()
        {
            //Arrange
            Odd TestOddList3 = new Odd();
            //Act
            List<int> result = TestOddList3.GenerateList(13);
            //Assert
            List<int> expectedList = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 };
            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}

