using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Integer
    {
        //This allows us to create a new instance of Fibonacci in any file except this one.
        public Fibonacci() : base()
        {
        }

        public List<int> GenerateFibonacciList(int listLength)
        {
            if (listLength > 1)
            {
                List<int> FibList = new List<int>() { 1, 1 };

                //(1,1,2,3,5,8,13,21,34,55,... n + n - 1)

                for (var i = 2; i < listLength; i++)
                {
                    int FibToAdd = FibList[i - 1] + FibList[i - 2];
                    FibList.Add(FibToAdd);
                }
                return FibList;
            }
            else
            {
                return new List<int>() { 1 };
            }
        }
    }
}
