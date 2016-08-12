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
            String switchToInt = Console.ReadLine();
            bool intNow = false;
            int listLength = 0;
            //this is switching our string-user-response to an integer
            //parse user listLength
            intNow = (Int32.TryParse(switchToInt, out listLength));
            if (listLength > 0)
            {
                //Loops to identify which user_numberType is selected  
                //Loop to make sure they entered a useable list length? no negative, no decimal?
                //Console.write new list 
                Console.WriteLine("OK, I am going to print out " + listLength + " " + user_numberType + "s ");
                Console.WriteLine("Here are your numbers! Whoopee!");
                if (user_numberType == "integer")
                {
                    //instantiate Integer
                    Integer myInteger = new Integer();
                    //we are creating a list for a new integer and applying the method(GenerateList) to create a list of integers
                    List<int> intList = myInteger.GenerateList(listLength);
                    //this is calling the method in the Integer.cs class to print the intList to screen
                    myInteger.ShowNumberListInConsole(intList);

                }
                else if (user_numberType == "even")
                {

                    //Integer myEven = new Integer();
                    //List<int> intList = myEven.GenerateList(listLength);
                    //myEven.ShowNumberListInConsole(intList);
                    Console.WriteLine("You picked evens!");
                }
                else if (user_numberType == "odd")
                {

                    //Integer myEven = new Integer();
                    //List<int> intList = myEven.GenerateList(listLength);
                    //myEven.ShowNumberListInConsole(intList);
                    Console.WriteLine("You picked odds!");
                }
                else if (user_numberType == "prime")
                {

                    //Integer myEven = new Integer();
                    //List<int> intList = myEven.GenerateList(listLength);
                    //myEven.ShowNumberListInConsole(intList);
                    Console.WriteLine("You picked primes!");
                }
                else if (user_numberType == "fibonacci")
                {

                    //Integer myEven = new Integer();
                    //List<int> intList = myEven.GenerateList(listLength);
                    //myEven.ShowNumberListInConsole(intList);
                    Console.WriteLine("You picked fibonaccis!");
                }
            }
            else
            {
                Console.WriteLine("only whole numbers please - no negatives");
                return; //this ends the program
            }
            Console.ReadLine();//ends the list length value check if loop
        }
    }
}
            
                    
                    

