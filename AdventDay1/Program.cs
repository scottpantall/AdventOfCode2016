/*
 * You're airdropped near Easter Bunny Headquarters in a city 
 * somewhere. "Near", unfortunately, is as close as you can get - 
 * the instructions on the Easter Bunny Recruiting Document the 
 * Elves intercepted start here, and nobody had time to work them 
 * out further.

The Document indicates that you should start at the given coordinates 
(where you just landed) and face North. Then, follow the provided 
sequence: either turn left (L) or right (R) 90 degrees, then walk 
forward the given number of blocks, ending at a new intersection.

There's no time to follow such ridiculous instructions on foot, 
though, so you take a moment and work out the destination. Given 
that you can only walk on the street grid of the city, how far is 
the shortest path to the destination?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay1
{ 
    class Program
    {
        enum Directions { North, East, South, West};
        struct Point{
            public int x;
            public int y;
        }

        static Directions AdjustDirection(Directions currDir, char turn)
        {
            Directions newDir = currDir;

            if (turn == 'L')
            {
                if(currDir == Directions.North)
                {
                    newDir = Directions.West;
                } else
                {
                    newDir--;
                }
            }

            if (turn == 'R')
            {
                if(currDir == Directions.West)
                {
                    newDir = Directions.North;
                } else
                {
                    newDir++;
                }
            }

            return newDir;
        }

        static void Main(string[] args)
        {
            string input = "L1, R3, R1, L5, L2, L5, R4, L2, R2, R2, L2, R1, L5, R3, L4, L1, L2, R3, R5, L2, R5, L1, R2, L5, R4, R2, R2, L1, L1, R1, L3, L1, R1, L3, R5, R3, R3, L4, R4, L2, L4, R1, R1, L193, R2, L1, R54, R1, L1, R71, L4, R3, R191, R3, R2, L4, R3, R2, L2, L4, L5, R4, R1, L2, L2, L3, L2, L1, R4, R1, R5, R3, L5, R3, R4, L2, R3, L1, L3, L3, L5, L1, L3, L3, L1, R3, L3, L2, R1, L3, L1, R5, R4, R3, R2, R3, L1, L2, R4, L3, R1, L1, L1, R5, R2, R4, R5, L1, L1, R1, L2, L4, R3, L1, L3, R5, R4, R3, R3, L2, R2, L1, R4, R2, L3, L4, L2, R2, R2, L4, R3, R5, L2, R2, R4, R5, L2, L3, L2, R5, L4, L2, R3, L5, R2, L1, R1, R3, R3, L5, L2, L2, R5";
            //string input = "R8, R4, R4, R8";
            Directions myDir = Directions.North;
            Point myPoint = new AdventDay1.Program.Point();
            List<Point> visits = new List<Point>();
            bool visited = false;
            int answer;

            myPoint.x = 0;
            myPoint.y = 0;
            visits.Add(myPoint);


            //Parse input string
            string[] instructions = input.Split(',');

            // Remove spaces from each instruction
            for(int i = 0; i < instructions.Length; i++)
            {
                instructions[i] = instructions[i].Trim();
            }
 
            foreach (string s in instructions)
            {
                //-If R, then add 1 to direction
                //-If L, then subtract 1 from direction
                myDir = AdjustDirection(myDir, s[0]);
                int j;

                switch (myDir)
                {
                    //--If direction is north, add to y
                    case Directions.North:
                        j = 0;
                        while (j < int.Parse(s.Substring(1)) && visited == false)
                        {
                            j++;

                            myPoint.y++;
                            if (visits.Contains(myPoint))
                            {
                                visited = true;
                            }
                            else
                            {
                                visits.Add(myPoint);
                            }
                        }
                        break;
                    //--If direction is south, subtract from y
                    case Directions.South:
                        j = 0;
                        while (j < int.Parse(s.Substring(1)) && visited == false)
                        {
                            j++;

                            myPoint.y--;
                            if (visits.Contains(myPoint))
                            {
                                visited = true;
                            }
                            else
                            {
                                visits.Add(myPoint);
                            }
                        }
                        break;
                    //--If direction is east, add to x
                    case Directions.East:
                        j = 0;
                        while (j < int.Parse(s.Substring(1)) && visited == false)
                        {
                            j++;

                            myPoint.x++;
                            if (visits.Contains(myPoint))
                            {
                                visited = true;
                            }
                            else
                            {
                                visits.Add(myPoint);
                            }
                        }
                        break;
                    //--If direction is west, subtract from x
                    case Directions.West:
                        j = 0;
                        while (j < int.Parse(s.Substring(1)) && visited == false)
                        {
                            j++;

                            myPoint.x--;
                            if (visits.Contains(myPoint))
                            {
                                visited = true;
                            }
                            else
                            {
                                visits.Add(myPoint);
                            }
                        }
                        break;
                }

                if(visited)
                {
                    break;
                }
            }

            answer = Math.Abs(myPoint.x) + Math.Abs(myPoint.y);

            Console.WriteLine("The first location visited twice is " + answer + " away.");
        }
    }
}
