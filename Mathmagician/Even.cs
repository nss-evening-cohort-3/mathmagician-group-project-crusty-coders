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
            this.EvenList = new List<int>();
        }

        public override List<int> IntegerList { get; set; }
        public List<int> EvenList { get; private set; }

        public override List<int> GenerateList(int listLength)
        {
            for (var i = 0; EvenList.Count != listLength; i++)
            {
                if (i % 2 == 0)
                {
                    EvenList.Add(i);
                }
            }
            return EvenList;
        }

        public int value { get; set; }

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
  