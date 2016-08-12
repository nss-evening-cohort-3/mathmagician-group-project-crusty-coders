using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        //private int answerSO;

        public Integer()
        //this is a constructor
        {
            IntegerList = new List<int>();
        }
        //virtual property list says it can be overridden by a child class such as odds  
        public virtual List<int> IntegerList { get; set; }
        //listLength is the variable we are getting from the user
        public virtual List<int> GenerateList(int listLength)
        {
            for (var i = 0; i < listLength; i++)
            {
                IntegerList.Add(i+1);
            }
            return IntegerList;
        }
        public void ShowNumberListInConsole(List<int> integers)
        {
            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
            }
        }
    }
}