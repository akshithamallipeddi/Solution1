using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Feb4
{
    class Exceptions
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int[] myNumbers = { 1, 2, 3 };
        //        Console.WriteLine(myNumbers[10]);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Something went wrong.");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("The 'try catch' is finished.");
        //    }
        //}
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
        }
    }
}
