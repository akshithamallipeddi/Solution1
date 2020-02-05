using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Feb4
{
    class Constructor
    {
        public string model;  // Create a field
        public string color;
        public int year;

        // Create a class constructor for the Constructor class
        public Constructor()
        {
            model = "Mustang"; // Set the initial value for model
        }
        public Constructor(string modelName)
        {
            model = modelName;
        }

        // Create a class constructor with multiple parameters
        public Constructor(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        //static void Main(string[] args)
        //{
        //    Constructor Ford = new Constructor();  // Create an object of the Constructor Class (this will call the constructor)
        //    Console.WriteLine(Ford.model);  // Print the value of model

        //    Constructor Ford1 = new Constructor("Mustang");
        //    Console.WriteLine(Ford1.model);

        //    Constructor Ford2 = new Constructor("Mustang", "Red", 1969);
        //    Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);

        //}
    }
}
