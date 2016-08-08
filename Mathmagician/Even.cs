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
        public int value { get; set; }
        //virtual property list says it can be overridden by a child class such as odds  
        public override List<int> IntegerList { get; set; }
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
       
        
    }
}
  