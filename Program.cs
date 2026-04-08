using System;
using System.Collections.Generic;

namespace BackTrackExplorer
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Stack<string> moves = new Stack<string>();

            //Welcome and Menue
            Console.WriteLine("Welcome to the BackTrack Explorer");
            Console.WriteLine("You can move: north, south, east, west");
            Console.WriteLine("Type 'Undo' to go back, 'History' to view previous, 'Exit' to get out the program ");

            //While Loop for Menue
            string command = "";

            while (command.ToLower() != "exit") 
            {
                Console.Write("Enter Command: ");
                command = Console.ReadLine().Trim().ToLower();


                switch (command.ToLower()) 
                {
                    case "north":
                        moves.Push("north");
                        Console.WriteLine($"You have moved {command}.");
                        break;
                    case "south":
                        moves.Push("south");
                        Console.WriteLine($"You have moved {command}.");
                        break;
                    case "east":
                        moves.Push("east");
                        Console.WriteLine($"You have moved {command}.");
                        break;
                    case "west":
                        moves.Push("west");
                        Console.WriteLine($"You have moved {command}.");
                        break;
                    case "undo":
                        if (moves.Count == 0)
                        {
                            Console.WriteLine("You cannot undo - no moves have been made yet");
                        }
                        else 
                        {
                            string lastMove = moves.Pop();
                            Console.WriteLine($"You have backtracked from going {lastMove}");
                        }
                        break;
                    case "history":
                        if (moves.Count == 0)
                        {
                            Console.WriteLine("You cannot view history - no moves have been made yet");
                        }
                        else 
                        {
                            /*
                            string lastMove = moves.Peek();
                            Console.WriteLine($"You move history is {lastMove}");
                            */
                            foreach (string item in moves) 
                            {
                                Console.WriteLine($"You have backtracked from going {item}");
                            }
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Exiting the Game. Goodbye adventurer.");
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}