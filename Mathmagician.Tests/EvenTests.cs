using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
        //Act

        Even my_even = new Even(); //new instance of even

        ////create a test checking to make sure we can create a list starting at zero
        // [TestMethod]
        // public void TestEvenGeneratingList()
        // {
        //    List<int> EvenList1 = new IntegerList<int>();
        //    List<int> EvenList1 = new List<int>() { 2, 4, 6, 8 };
        //    CollectionAssert.AreEqual(EvenList1, EvenList1.IntegerList[4]);

            //You need to access it via the TestList object you created


       //    so `TestList.IntegerList[4]` or `TestList.IntegerList.ElementAt(4)`
       }

    }

