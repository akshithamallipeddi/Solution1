using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Feb4
{
    // Abstract class
    abstract class Animal1
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig1 : Animal1
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Abs
    {
        //static void Main(string[] args)
        //{
        //    Pig1 myPig = new Pig1(); // Create a Pig object
        //    myPig.animalSound();  // Call the abstract method
        //    myPig.sleep();  // Call the regular method
        //}
    }
}
