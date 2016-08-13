using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime : Integer
    {
        public Prime() : base()
        {
            this.PrimeList = new List<int>();
        }

        //overriding the IntegerList 
        //also inherits invisible method like ShowNumberListInConsole
        public override List<int> IntegerList { get; set; }
        public List<int> PrimeList { get; private set; }

        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public override List<int> GenerateList(int listLength)
        {
            for (int i = 1; PrimeList.Count != listLength; i++)
            {
                if (isPrime(i))
                {
                    PrimeList.Add(i);
                }
            }
            return PrimeList;
        }
    }
}
 





 

