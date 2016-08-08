using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]//annotation
    public class UnitTest1
    {
        public void ThisIsNotATest()
        {

        }
        //ok to use above method ThisISNotATest in the tests below because it is not a test.

        [TestMethod]
        public void TestThatThisIsTrue()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(true);
        }
        
       
    }
}
