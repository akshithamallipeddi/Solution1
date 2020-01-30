using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1 # Output");
            int n = 5;
            PrintPattern(n);

            Console.WriteLine();
            Console.WriteLine("Question 2 # Output");
            int n2 = 6;
            PrintSeries(n2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 3 # Output");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);


            Console.WriteLine("Question 4 # Output");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine();
            Console.WriteLine("Question 5 # Output");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine();
            Console.WriteLine("Question 6 # Output");
            Stones(5);
        }

        private static StringBuilder sb = new StringBuilder();
        private static void PrintPattern(int n)
        {
            int s;
            try
            {
                if (n <= 0)
                {
                    //Print N/A if n is less than or equal  to 0
                    Console.WriteLine("N/A");
                    return;
                }
                if (n == 1)
                {
                    sb.Append("1");
                    //Print the generated string
                    Console.WriteLine(sb);

                    //If the length of the string is greater than 1, then generating the next lime of the print series
                    s = sb.Length;
                    if (s > 1)
                    {
                        //Clear the existing string
                        sb = new StringBuilder();
                        //Call the function to generate the next line
                        PrintPattern(s - 1);
                    }
                    return;
                }

                //String builder to append the numbers as string
                sb.Append(n.ToString());
                //Call the function recursively until n == 1 is reached
                PrintPattern(n - 1);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                if (n2 <= 0)
                {
                    //Print N/A if number less than or equal to 0 
                    Console.WriteLine("N/A");
                }
                else
                {
                    //Print the first number
                    Console.Write("1");
                    for (int i = 2; i <= n2; i++)
                    {
                        //Computing the sum using the formula (n*(n+1))/2 and writing to Console 
                        Console.Write(", " + (i * (i + 1)) / 2);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                //Getting the hours, mins, secs from input string
                int hours = Convert.ToInt32(s.Substring(0, 2));
                int mins = Convert.ToInt32(s.Substring(3, 2));
                int secs = Convert.ToInt32(s.Substring(6, 2));
                //Getting AM or PM from input string
                string period = s.Substring(8, 2);

                //Calculating the Total number of seconds in the input string
                int totalSecs = hours * 60 * 60 + mins * 60 + secs;
                //Adding secs depending on period value
                if (period == "PM")
                    totalSecs = totalSecs + 12 * 60 * 60;


                //Converting to USF time by dividing the totalsecs with respect to USF's time
                int u = totalSecs / (45 * 60);
                int s1 = (totalSecs - u * 45 * 60) / 45;
                int f = (totalSecs - u * 45 * 60 - s1 * 45);

                // returning the USF time
                return(u.ToString().PadLeft(2, '0') + ":" + s1.ToString().PadLeft(2, '0') + ":" + f.ToString().PadLeft(2, '0'));
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
                return null;
            }
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int a = 1;
                int s = 1;
                while (n3 > 0)
                {
                    for (int i = s; i <= k * a; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                        {
                            //If number is divisible by 3, writing U to console
                            if (i % 3 == 0)
                                Console.Write("U");
                            //If number is divisible by 5, writing S to console
                            if (i % 5 == 0)
                                Console.Write("S");
                            //If number is divisible by 7, writing F to console
                            if (i % 7 == 0)
                                Console.Write("F");
                        }
                        else
                            Console.Write(i);
                        Console.Write(" ");
                    }
                    //Calculating the numbers still to be printed
                    n3 = n3 - k;
                    //Calculating the first number for the next line
                    s = k * (a) + 1;
                    //Storing the line number
                    a = a + 1;
                    Console.Write(Environment.NewLine);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }

        public static void PalindromePairs(string[] words)
        {
            List<string> s = new List<String>();
            try
            {
                // Write your code here
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (CheckIfPalindrome(words[i], words[j]))
                        {
                            s.Add("[" + i + "," + j + "]");
                        }
                        if (CheckIfPalindrome(words[j], words[i]))
                        {
                            s.Add("[" + j + "," + i + "]");
                        }
                    }
                }
                Console.WriteLine("[{0}]", string.Join(",", s));
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        private static bool CheckIfPalindrome(string a, string b)
        {
            if (!String.IsNullOrEmpty(a) && !String.IsNullOrEmpty(b))
            {
                string reverse = string.Empty;
                string input = string.Concat(a, b);
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i].ToString();
                }
                if (reverse == input)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static void Stones(int n4)
        {
            try
            {
                IEnumerable<IEnumerable<int>> finalResult = new List<List<int>>();
                string finalOutput = "";

                //Loop to get all the possible permutations of 1,2,3 and the last stone is picked by player 1
                for (int i = 1; i < n4; i = i + 2)
                {
                    //Get all permuations with total number of turns as 'i'
                    IEnumerable<IEnumerable<int>> result = GetPermutations(Enumerable.Range(1, 3), i);

                    //Only pick if sum == n4 and the sum of last 2 is greater than 3
                    result = result.Where(t => t.Sum(a => Int32.Parse(a.ToString())) == n4 && t.Skip(i - 2).Sum(a => Int32.Parse(a.ToString())) > 3).Distinct();

                    //Add the items to the finalResult
                    foreach (var item in result)
                        finalResult = finalResult.Append(item);
                }
                if (finalResult.Count() > 0)
                {
                    //Building the final output
                    foreach (var r in finalResult)
                    {
                        if (!string.IsNullOrEmpty(finalOutput))
                            finalOutput += " or ";
                        finalOutput += $"[{string.Join(", ", r)}]";
                    }
                }

                //Printing the output
                if (string.IsNullOrEmpty(finalOutput))
                    Console.WriteLine("false");
                else
                    Console.WriteLine(finalOutput);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            //Get all the permutations of the list with the length
            if (length == 1)
                return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1).SelectMany(t => list, (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}