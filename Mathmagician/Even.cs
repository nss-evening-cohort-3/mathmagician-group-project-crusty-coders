using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer
    {
        public Even() : base()
        {
            //we want to create a collection of Even Integers
            IntegerList.Add(2);
        }
        //methods we need to have available for testing
        public int Modulo(int divisor)
        {
            return 0;
        }
        public void EvenDivisibleByTwo()
        {
            Even numE = new Even()
            {
            };
        }
        public int value { get; set; }
    }
}
  