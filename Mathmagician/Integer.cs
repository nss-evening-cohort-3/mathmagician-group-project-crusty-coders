using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public Integer()
        {
        }
        public Integer(string userInput)
        //this is a constructor
        {
             //int.TryParse returns a boolean
            if (int.TryParse(userInput, out i))
            //giving the method of TryPars a  reference to i outside of its scope
            {
                if (i > 0)
                { //initialize integer object here    
                }
                else
                {
                    throw new Exception("Sorry, that won't work for this!");
                }
            }
            else
            {
                //you didn't give me an integer
                throw new ArgumentException("Sorry, that won't work!");
            }
        
        }
        int i;
        //operations here, add, subtract, multiply, modulo
        public int Multiply(int firstNumber, int secondNumber)
        {
            var answerMulty = firstNumber * secondNumber;
            return answerMulty;

            // private List<int> answer = new List<int>();

        }
        public int AddTwo(int firstNumber)
        {
            var answerAddTwo = firstNumber + 2;
            return answerAddTwo;

            // private List<int> answer = new List<int>();
        }
        public int SubtractOne(int x)
        {
            var answerSO = (x - 1);
            return answerSO; 
        }
        public int ModuloTwo(int y)
        {
            var answerModTwo = (y % 2);
            return answerModTwo;
        }

    }
}