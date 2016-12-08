using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<string> possibleTriangles = new List<string>();
            int answer;
            char[] delimiters = { ' ' };

            // Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader("../../input.txt");

            while ((line = file.ReadLine()) != null)
            {
                string[] numbers;

                line = line.Trim();
                numbers = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                

                if(int.Parse(numbers[0]) + int.Parse(numbers[1]) > int.Parse(numbers[2]))
                {
                    possibleTriangles.Add(line);
                }
            }

            answer = possibleTriangles.Count();

            Console.WriteLine("There are " + answer + " possible triangles.");
        }
    }
}
