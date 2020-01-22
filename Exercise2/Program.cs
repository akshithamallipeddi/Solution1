using System;

namespace Exercise2
{
	class Program
	{
		static void Main(string[] args)
		{
			int age, height;
			//Max heart rate is equal 220-age

			age = 46;
			height = 60;

			//Console should write: I am ### years old, my max heart rate is ## and I an ## inches tall.
			Console.Write("I am " + age + " years old, my max heart rate is " + (220 - age) + " and I am " + height + " inches tall.");
		}
	}
}
