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
            int answer = 0;
            int count = 0;
            char[] delimiters = { ' ' };
            List<int> column1 = new List<int>();
            List<int> column2 = new List<int>();
            List<int> column3 = new List<int>();

            // Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader("../../input.txt");

            while ((line = file.ReadLine()) != null)
            {
                string[] numbers;

                line = line.Trim();
                numbers = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                column1.Add(int.Parse(numbers[0]));
                column2.Add(int.Parse(numbers[1]));
                column3.Add(int.Parse(numbers[2]));

                count++;

                if(count == 3)
                {
                    if(column1.ElementAt(0) + column1.ElementAt(1) > column1.ElementAt(2) &&
                        column1.ElementAt(1) + column1.ElementAt(2) > column1.ElementAt(0) &&
                        column1.ElementAt(2) + column1.ElementAt(0) > column1.ElementAt(1))
                    {
                        answer++;
                    }

                    if (column2.ElementAt(0) + column2.ElementAt(1) > column2.ElementAt(2) &&
                        column2.ElementAt(1) + column2.ElementAt(2) > column2.ElementAt(0) &&
                        column2.ElementAt(2) + column2.ElementAt(0) > column2.ElementAt(1))
                    {
                        answer++;
                    }

                    if (column3.ElementAt(0) + column3.ElementAt(1) > column3.ElementAt(2) &&
                        column3.ElementAt(1) + column3.ElementAt(2) > column3.ElementAt(0) &&
                        column3.ElementAt(2) + column3.ElementAt(0) > column3.ElementAt(1))
                    {
                        answer++;
                    }

                    count = 0;
                    column1.RemoveRange(0, column1.Count());
                    column2.RemoveRange(0, column2.Count());
                    column3.RemoveRange(0, column3.Count());

                }
            }

            Console.WriteLine("There are " + answer + " possible triangles.");
        }
    }
}
