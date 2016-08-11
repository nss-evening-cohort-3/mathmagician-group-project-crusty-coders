using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            //interaction with user 
            String prompt = "> ";
            Console.WriteLine("Welcome to the Mathmagician!Would you like an Integer, Prime, Fibonacci, Even or Odd list of numbers?");
            Console.Write(prompt);
            String user_numberType = Console.ReadLine().ToLower();
            Console.WriteLine("How long would you like your list?");
            Console.Write(prompt);
            String user_listLength = Console.ReadLine();
            String result = "OK, I am going to print out {user_numberType}{user_numberChoice}";
            String mistake = "Nope - that is not an acceptable response!";

            //Loops to identify which user_numberType is selected  
                //Loop to make sure they entered a useable list length? no negative, no decimal?
                //Console.write new list    
            if (user_numberType == "integer")
            {
                //instantiate Integer
                Integer integer = new Integer();
                //generate Integer list

            }
            }
    }
}
