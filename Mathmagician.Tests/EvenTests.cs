using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateAnInstanceOf()
        {
            Even my_even = new Even();

            Assert.IsNotNull(my_even);
        }
    }
}

