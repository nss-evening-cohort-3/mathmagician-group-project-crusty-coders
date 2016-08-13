using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd : Integer
    {
        public Odd() : base()
        {
            this.OddList = new List<int>();
        }
        //overriding the IntegerList 
        //also inherits invisible method like ShowNumberListInConsole
        public override List<int> IntegerList { get; set; }
        public List<int> OddList { get; private set; }

        public override List<int> GenerateList(int listLength)
        {
            for (var i = 0; OddList.Count != listLength; i++)
            {
                if (i % 2 != 0)
                {
                    OddList.Add(i);
                }
            }
            return OddList;
        }
    }
 }

