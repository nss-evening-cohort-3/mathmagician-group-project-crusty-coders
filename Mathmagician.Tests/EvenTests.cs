using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateAnInstance()//of a class
        {
            //Arrange
            //Act - we're writing code that doesn't exist yet
            Even my_even = new Even(); //what I want to be ABLE to do

            //Assert
            Assert.IsNotNull(my_even);
        }
       //create a test checking to make sure we can create a list starting at zero
        [TestMethod]
        public void TestEvenGeneratingList()
        {
            //Arrange
            Even TestEvenList1 = new Even();
            //Act
            List<int> result = TestEvenList1.GenerateList(2);
            //Assert
            List<int> expectedList = new List<int>() { 0, 2 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList2()
        {
            //Arrange
            Even TestEvenList2 = new Even();
            //Act
            List<int> result = TestEvenList2.GenerateList(6);
            //Assert
            List<int> expectedList = new List<int>() { 0, 2, 4, 6, 8, 10 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList3()
        {
            //Arrange
            Even TestEvenList3 = new Even();
            //Act
            List<int> result = TestEvenList3.GenerateList(13);
            //Assert
            List<int> expectedList = new List<int>() { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 };
            CollectionAssert.AreEqual(expectedList, result);
        }
      }

    }

