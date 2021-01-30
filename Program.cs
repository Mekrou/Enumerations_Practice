//
// Just enum practice...
// 
// Created by Mekrou 01/30/2021
//

using System;

namespace Enumerations
{
    class Program
    {

        enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            DaysOfWeek today; // Declaring our own custom made variable from our enum!
            today = DaysOfWeek.Saturday;
            
            Console.WriteLine("Today is: " + today);

            // Enums under the hood are wrapped into underlying types (default int).
            // That means we can cast them into integers. They are indexed from 0,
            // so the code bellow will print 6.

            Console.WriteLine("Today is: " + (int) today);
        }
    }
}
