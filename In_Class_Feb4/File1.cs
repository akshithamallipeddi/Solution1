using System;
using System.Collections.Generic;
using System.Text;
using System.IO;  // include the System.IO namespace

namespace In_Class_Feb4
{
    class File1
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }
    }
}
