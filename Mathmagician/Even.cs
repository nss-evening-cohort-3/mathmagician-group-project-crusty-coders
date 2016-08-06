using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer
    {
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
  