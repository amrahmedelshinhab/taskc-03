namespace task03
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlTypes;
    using System.Diagnostics.Metrics;
    using System.Runtime.Intrinsics.X86;
    using System.Text;
    using static System.Net.Mime.MediaTypeNames;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main(string[] args)

        //             Problem: Write a program to: 
        //o Accept a string input from the user.
        //o Convert it to an integer using both int.Parse and Convert.ToInt32.
        //o Handle potential exceptions using a try-catch block.
        //console.writeline("enter a string to convert to an integer:");


        //string userinput = console.readline();

        //try
        //{
        //    int parsedvalue = int.parse(userinput);
        //    console.writeline($"int.parse successfully converted '{userinput}' to {parsedvalue}.");
        //}
        //catch (formatexception)
        //{
        //    console.writeline("int.parse: input string is not in a correct format.");
        //}
        //catch (overflowexception)
        //{
        //    console.writeline("int.parse: input number is too large or too small for an int32.");
        //}

        //try
        //{

        //    int convertedvalue = convert.toint32(userinput);
        //    console.writeline($"convert.toint32 successfully converted '{userinput}' to {convertedvalue}.");
        //}
        //catch (formatexception)
        //{
        //    console.writeline("convert.toint32: input string is not in a correct format.");
        //}
        //catch (overflowexception)
        //{
        //    console.writeline("convert.toint32: input number is too large or too small for an int32.");
        //}

        //console.writeline("program execution completed.");




        //             Problem: Write a program that: 
        //o Prompts the user to input a number. 
        //o Uses int.TryParse to check if the input is a valid integer.
        //o If valid, print the number; otherwise, print an error message.





        //        {
        //            Console.WriteLine("Please enter a number:");

        //            // Accept user input
        //            string userInput = Console.ReadLine();

        //            // Use int.TryParse to validate and convert the input
        //            if (int.TryParse(userInput, out int number))
        //            {
        //                // Input is valid
        //                Console.WriteLine($"You entered a valid number: {number}");
        //            }
        //            else
        //            {
        //                // Input is invalid
        //                Console.WriteLine("Error: The input is not a valid integer.");
        //            }
        //        }
        //    }



        //}

        //             Problem: Implement a program to: 
        //o Declare an object variable.
        //o Assign it different data types (e.g., int, string, double). 
        //o Print the GetHashCode() of each assignment.




        //         Problem: Demonstrate how changing one reference affects another when both point to
        //the same object. Use the following steps: 
        //o Create an object and assign it a value.
        //o Create a second reference to the same object. 
        //o Modify the value of the object using one reference and print the value using the 
        //other.

        //    {

        //        var obj1 = new MyClass { Value = 10 };
        //        Console.WriteLine($"Initial Value of obj1: {obj1.Value}");

        //        var obj2 = obj1; 
        //        Console.WriteLine($"Initial Value of obj2: {obj2.Value}");

        //        obj1.Value = 30;

        //        Console.WriteLine($"Value of obj1 after modification: {obj1.Value}");
        //        Console.WriteLine($"Value of obj2 after modification: {obj2.Value}");
        //    }
        //}

        //class MyClass
        //{
        //    public int Value { get; set; }
        //}




        //             Problem: Write a program to: 
        //o Declare a string and modify it by concatenating additional text “Hi Willy”. 
        //o Print the GetHashCode() before and after modification.


        //            {

        //        string originalString = "Hello";

        //        Console.WriteLine($"Original String: {originalString},  {originalString.GetHashCode()}");


        //        string modifiedString = originalString + " Hi Willy";

        //        Console.WriteLine($"Modified String: {modifiedString}, {modifiedString.GetHashCode()}");
        //    }
        //}

        //             Problem: Create a program to: 
        //o Use StringBuilder to append text to a string “Hi Willy”. 
        //o Print the GetHashCode() of the StringBuilder instance before and after the
        //modification.

        //    {
        //        StringBuilder sb = new StringBuilder("Hi Willy");

        //        sb.Append(" - Welcome!");

        //        Console.WriteLine($"Before modification: {sb.ToString()},  {sb.GetHashCode()}");



        //        Console.WriteLine($"After modification: {sb.ToString()},  {sb.GetHashCode()}");
        //    }
        //}



        //             Problem: Create a program using StringBuilder to: 
        //o Append text.
        //o Replace a substring.
        //o Insert a string at a specific position.
        //o Remove a portion of text. 


    //    {
    //        StringBuilder sb = new StringBuilder("Hello World");

           
    //        sb.Append("! How are you?");
    //        Console.WriteLine($"After Append: {sb.ToString()}");

         
    //        sb.Replace("World", "Universe");
    //        Console.WriteLine($"After Replace: {sb.ToString()}");

        
    //        sb.Insert(6, "Beautiful ");
    //        Console.WriteLine($"After Insert: {sb.ToString()}");

           
    //        sb.Remove(6, 10); 
    //        Console.WriteLine($"After Remove: {sb.ToString()}");
    //    }
    //}sssss
}