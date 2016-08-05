﻿using System;
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
            Assert.AreEqual( i, userInput);
        }
        [TestMethod]
        public void IntegerMultiplyWorks()
        {
            Integer Multiply = new Integer();
            int answerMulty = Multiply.Multiply(6, 7);
            Assert.AreEqual( (42), answerMulty );
        }
        [TestMethod]
        public void IntegerAddTwo()
        {
            Integer AddTwo = new Integer();
            int answerAddTwo = AddTwo.AddTwo(3);
            Assert.AreEqual((5), answerAddTwo );
        }
        [TestMethod]
        public void IntegerSubtractOne()
        {
            Integer SubtractOne = new Integer();
            int answerSO = SubtractOne.SubtractOne(5);
            Assert.AreEqual((4), answerSO);            
        }
        [TestMethod]
        public void IntegerModuloTwo()
        {
            Integer ModuloTwo = new Integer();
            int answerModTwo = ModuloTwo.ModuloTwo(10);
            Assert.AreEqual((0), answerModTwo);
        }
    }
}
