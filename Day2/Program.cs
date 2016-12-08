using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] keypad = new string[5, 5];
            keypad[0, 0] = "X";
            keypad[0, 1] = "X";
            keypad[0, 2] = "1";
            keypad[0, 3] = "X";
            keypad[0, 4] = "X";
            keypad[1, 0] = "X";
            keypad[1, 1] = "2";
            keypad[1, 2] = "3";
            keypad[1, 3] = "4";
            keypad[1, 4] = "X";
            keypad[2, 0] = "5";
            keypad[2, 1] = "6";
            keypad[2, 2] = "7";
            keypad[2, 3] = "8";
            keypad[2, 4] = "9";
            keypad[3, 0] = "X";
            keypad[3, 1] = "A";
            keypad[3, 2] = "B";
            keypad[3, 3] = "C";
            keypad[3, 4] = "X";
            keypad[4, 0] = "X";
            keypad[4, 1] = "X";
            keypad[4, 2] = "D";
            keypad[4, 3] = "X";
            keypad[4, 4] = "X";
            int row = 2;
            int column = 0;
            string answer = "";

            int counter = 0;
            string line;

            // Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader("../../input.txt");

            while((line = file.ReadLine()) != null)
            {
                for(int i = 0; i < line.Length; i++)
                {
                    switch(line[i])
                    {
                        case 'U':
                            if(row != 0)
                            {
                                row--;
                                if(keypad[row,column] == "X")
                                {
                                    row++;
                                }
                            }
                            break;
                        case 'D':
                            if(row != 4)
                            {
                                row++;
                                if (keypad[row, column] == "X")
                                {
                                    row--;
                                }
                            }
                            break;
                        case 'R':
                            if(column != 4)
                            {
                                column++;
                                if (keypad[row, column] == "X")
                                {
                                    column--;
                                }
                            }
                            break;
                        case 'L':
                            if(column != 0)
                            {
                                column--;                                
                                if (keypad[row, column] == "X")
                                {
                                    column++;
                                }
                            }
                            break;
                    }
                }

                answer = answer + keypad[row, column];
                //Console.WriteLine(line);
                counter++;
            }
            Console.WriteLine("The code is " + answer);

            file.Close();
        }
    }
}
