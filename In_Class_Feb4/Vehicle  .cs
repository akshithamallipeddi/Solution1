using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Feb4
{
    class Vehicle
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car4 : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Program4
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car4 myCar = new Car4();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
