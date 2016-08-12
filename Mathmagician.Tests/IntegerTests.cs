using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        public object userInput;

        public object i { get; set; }

        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()//of a class
        {
            //Arrange

            //Act - we're writing code that doesn't exist yet
            Integer my_int = new Integer(); //what I want to be ABLE to do
            //Assert
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void IntegerEnsureUserInputIsAnInteger()
        {
            Assert.AreEqual(i, userInput);
        }

        //[TestMethod]
        //public void IntegerSubtractOne()
        //{
        //    Integer SubtractOne = new Integer();
        //    int answerSO = SubtractOne.SubtractOne(5);
        //    Assert.AreEqual((4), answerSO);
        //}
        //[TestMethod]
        //public void IntegerModuloTwo()
        //{
        //    Integer ModuloTwo = new Integer();
        //    int answerModTwo = ModuloTwo.ModuloTwo(10);
        //    Assert.AreEqual((0), answerModTwo);
        //}
        //create a test checking to make sure we can create a list starting at zero
        [TestMethod]
        public void TestGeneratingList()
       {    
            //Arrange
           Integer TestList = new Integer();
            //Act
            List<int> result = TestList.GenerateList(4);
           //Assert
          List<int> expectedList = new List<int>() { 1, 2, 3, 4 };
          CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList2()
        {
            //Arrange
            Integer TestList2 = new Integer();
            //Act
            List<int> result = TestList2.GenerateList(2);
            //Assert
            List<int> expectedList = new List<int>() { 1, 2 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList3()
        {
            //Arrange
            Integer TestList2 = new Integer();
            //Act
            List<int> result = TestList2.GenerateList(11);
            //Assert
            List<int> expectedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}