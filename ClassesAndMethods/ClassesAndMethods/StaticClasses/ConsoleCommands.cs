using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndMethods.StaticClasses
{

    /// <summary>
    /// This is a static class.  It functions without having to create a "new object" of a class.
    /// 
    /// It just works by ensuring that the ClassesAndMethods.StaticClasses namespace is available.
    /// 
    /// If this namespace is available any "Method" inside of this class can be called directly with the following code:
    /// 
    ///     ConsoleCommands.{Name of the method to execute}
    ///     
    /// Example:
    ///     
    ///     ConsoleCommans.PrintMessage("This is my message", true);
    /// 
    /// </summary>
    public static class ConsoleCommands
    {


        /// <summary>
        /// Method for writing a line a message to the console screen.
        /// 
        /// The first "argument" is the message to be printed
        /// The second "argument" is a true/false value to allow for "newline" or not.
        /// 
        /// Example Uses:
        /// 
        ///     ConsoleCommands.PrintLine("Please choose one of the following:", true);
        ///     
        ///     ConsoleCommands.PrintLine("This will not go to the next line.", false);
        /// 
        ///     ConsoleCommands.PrintLine("This is just a 'wrapper' for the Console.Write(Line) class methods", true);
        ///     
        /// </summary>
        /// <param name="message"></param>
        /// <param name="includeNewLine"></param>
        public static void PrintMessage(string message, bool includeNewLine)
        {

            // we check to see if the "input argument" is true or false
            if(includeNewLine)
            {
                // if the "input argument" is true, we execute this code "block"
                Console.WriteLine(message);
            }
            else
            {
                // if the "input argument" is false, we execute this code "block"
                Console.Write(message);
            }
        }


        public static string ReadMessage()
        {
            // In this line we create a variable message.
            //      It will be an integer if you input an interger.. this can be a problem since we are "returning" a string.
            //      Because of this, after we "ReadLine()" what a user types, 
            //                       we will ALWAYS convert it to a string before sending it back to the "caller"
            var message = Console.ReadLine();



            // This is where we will "Convert" the message to a string to ensure when we pass it back, even if the use
            // input a number, it will return as a string.  The "caller" can check for numbers if they want in their own code.
            // 
            // We do not check for numbers and other things here, because it is important to keep things simple.
            return Convert.ToString(message) ;
        }

    }
}
