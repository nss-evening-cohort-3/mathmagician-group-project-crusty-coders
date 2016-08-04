using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public Integer(string userInput)
        //this is a constructor
        {
            int i;
            //int.TryParse returns a boolean
            if (int.TryParse(userInput, out i))
            //giving the method of TryPars a  reference to i outside of its scope
            {
                if (i > 0)
                { //initialize integer object here

                }
                else
                {
                    //alert you didn't give me a positive number
                }
            }
            else

            //you didn't give me an integer
            {
            }
        }
        //operations here, add, subtract, multiply, divide, modulo


        // {
        // if any key on the keyboard other than a number 
        //is pressed, (i.e. letter, symbol, space bar, etc.)
        //throw an exception and make user
        //re-enter
        //some kind of
        //  }

    }
}