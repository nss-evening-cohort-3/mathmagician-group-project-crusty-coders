using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void EnsureFibonacciInstance()
        {
            Fibonacci myFib = new Fibonacci();
            Assert.IsNotNull(myFib);
        }
   
        [TestMethod]
        public void TestFibGenList()
        {
            //Arrange
            Fibonacci TestFibList1 = new Fibonacci();
            //Act
            List<int> result = TestFibList1.GenerateFibonacciList(2);
            //Assert
            List<int> expectedList = new List<int>() { 1, 1 };
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestFibGenList2()
        {
            //Arrange
            Fibonacci TestFibList2 = new Fibonacci();
            //Act
            List<int> result = TestFibList2.GenerateFibonacciList(5);
            //Assert
            List<int> expectedList = new List<int>() { 1, 1, 2, 3, 5};
            CollectionAssert.AreEqual(expectedList, result);
        }
        [TestMethod]
        public void TestFibGenList3()
        {
            //Arrange
            Fibonacci TestFibList3 = new Fibonacci();
            //Act
            List<int> result = TestFibList3.GenerateFibonacciList(10);
            //Assert
            List<int> expectedList = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}
