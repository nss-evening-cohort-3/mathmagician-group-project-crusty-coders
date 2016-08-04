using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.Equals( i, userInput);
        }
    }
}
