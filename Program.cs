using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week9Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path: ");

            string input = @"" + Console.ReadLine();

            var numChecker = new Regex(@"^[A-Z]+\W\W([A-Za-z0-9]+\W*)+\w{3}$");

            int counter = 0;

            string nonletters = " ,.";

            string line;

            string[] next;

            try
            {
                if (numChecker.IsMatch(input))
                {

                    Console.WriteLine("File path is valid");

                    Console.WriteLine(input);

                    StreamReader sr = new StreamReader(input);

                    do
                    {

                        line = sr.ReadLine();
                        if (line != null)
                        {
                            line.Trim();
                            Console.WriteLine(line);
                            next = line.Split(nonletters.ToCharArray());
                            counter += next.Length;
                        }
                    }
                    while (line != null);

                    Console.WriteLine("There are " + counter + " words in the file.");
                }
                else
                    Console.WriteLine("Not a valid file path!");
            }
            catch(FormatException)
            {
                Console.WriteLine("Unfortunately, that file does not exist");
            }
        }
    }
}
