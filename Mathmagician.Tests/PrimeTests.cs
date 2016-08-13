using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        //Instantiation test
        public void PrimeEnsureICanCreateAnInstance()//of a Prime class or object
        {
            //Arrange
            //Act - we're writing code that doesn't exist yet
            Prime my_prime = new Prime(); //what I want to be ABLE to do

            //Assert
            Assert.IsNotNull(my_prime);
        }
        [TestMethod]
        public void TestGeneratingList1()
        {
            //Arrange
            Prime TestPrimeList1 = new Prime();
            //Act
            List<int> result = TestPrimeList1.GenerateList(2);
            //Assert
            List<int> expectedList = new List<int>() { 2, 3 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestGeneratingList2()
        {
            //Arrange
            Prime TestPrimeList2 = new Prime();
            //Act
            List<int> result = TestPrimeList2.GenerateList(5);
            //Assert
            List<int> expectedList = new List<int>() { 2, 3, 5, 7, 11 };
            CollectionAssert.AreEqual(expectedList, result);
        }
    }


}
