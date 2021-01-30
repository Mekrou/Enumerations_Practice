//
// A simple program that will prompt a user to enter a number 1-12 and print back the month that number represents...
// Using Enumerations, of course!  
//
// Commented code was old practice.
//
// Created by Mekrou 01/30/2021
//

using System;

namespace Enumerations
{
    class Program
    {
        // enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        // Second enum MonthsOfYear will be used to demonstrate assigning numbers to values.
        enum MonthsOfYear {January = 1, Febuary = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12};
        

        static void Main(string[] args)
        {
            // This will hold user input
            int userInput = 0;  
            // This will hold our casted value at the end of the program.  
            MonthsOfYear userChoice = MonthsOfYear.January;

            // Prompt user
            Console.WriteLine("Welcome, please enter a number 1-12 to represent a month of your choice.");
            Console.WriteLine();
            
            // We keep the user in an input loop.
            while (true)
            {
                // Using a try/catch, we can avoid crashes.
                try 
                {
                    // Grabbing user input
                    userInput = Convert.ToInt32(Console.ReadLine());
                    
                    // Checking if they entered a number 1-12. If they didn't, the while loop will restart.
                    if (userInput >= 1 && userInput <= 12)
                    {
                        break;
                    } else {
                        PrintInvalidInput();
                    }       
                } 
                catch (Exception)
                {
                    PrintInvalidInput();
                }
            }

            // Converting the user's number into the value (in this case name) it references.
            userChoice = (MonthsOfYear) userInput;

            Console.WriteLine("You chose: " + userChoice);

                    
            // DaysOfWeek today; // Declaring our own custom made variable from our enum!
            // today = DaysOfWeek.Saturday;
            
            // Console.WriteLine("Today is: " + today);

            // // Enums under the hood are wrapped into underlying types (default int).
            // // That means we can cast them into integers. They are indexed from 0,
            // // so the code bellow will print 6.

            // Console.WriteLine("Today is: " + (int) today);
        }

        static void PrintInvalidInput()
        {
            Console.WriteLine("That is not a valid number, please try again!");
        }
    }
}
