using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Feb4
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Interface
    {
        //static void Main(string[] args)
        //{
        //    DemoClass myObj = new DemoClass();
        //    myObj.myMethod();
        //    myObj.myOtherMethod();
        //}
    }
}
