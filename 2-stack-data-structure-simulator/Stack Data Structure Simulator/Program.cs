using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        //global variable declation
        static string[] crd = { "A-6", "H-5", "D-9" };
        static Stack<string> cards = new(crd);
        static bool b1 = true, b2 = true, b3 = true;

        //_____________________________________________________________________________________________________________________________________
        static void Main(string[] args)
        {
            while (b1) //using loop for multiple use of operations
            {
                //resetting values to repeat filtering data for at least 2 operations
                int option = 0;
                b2 = true; b3 = true; ;
                while (b2)
                {
                    Console.Write("\n\t>>>Operations<<<\n\t[1] Push\n\t[2] Pop\n\n\tEnter Operation:   ");
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write("\n\tInvalid operation! Please try again.\n\n");
                    if ((option == 1) || (option == 2))
                        b2 = false;
                }

                //option 1 for push operation
                if (option == 1)
                {
                    Console.Clear();
                    Console.Write("\n\tPush Operation\n\t______________________________________________________________________\n\n\tEnter card: ");
                    string card = Console.ReadLine();

                    //code to be execute if the inputted card already exists
                    if (cards.Contains(card))
                    {
                        Console.WriteLine("\n\tAdding failed. " + card + " is already in the stack of cards.\n");
                        DisplayStack();
                        KeyFilter();
                    }

                    //code to be execute if the inputted card does not exist
                    else
                    {
                        cards.Push(card);
                        Console.WriteLine("\n\t" + card + " was successfully added at the top of stack of cards.\n");
                        DisplayStack();
                        KeyFilter();
                    }
                }

                //option 1 for push operation
                if (option == 2)
                {
                    Console.Clear();
                    //checking if stock is empty
                    if (cards.Count == 0) //Notifying the user that stack is empty
                    {
                        Console.WriteLine("\n\tStack is empty. Unable to perform pop operation.");
                        KeyFilter();
                    }
                    else //Deleting the card at the top of the stack
                    {
                        Console.WriteLine("\n\tPop operation has been performed. " + cards.Peek() + " successfully deleted from the stack.\n");
                        cards.Pop();
                        DisplayStack();
                        KeyFilter();
                        Console.Clear();
                    }
                }
            }
        }
        //____________________________________________________________________________________________________________________________________

        //function to dislay cards in the stack
        static void DisplayStack()
        {
            if (cards.Count != 0)
            {
                Console.WriteLine("\n\t>>>List of cards in the stack(from top to bottom)<<<");
                foreach (string card in cards)
                    Console.WriteLine("\t" + card);
            }
            else
                Console.WriteLine("\n\tThe stock was already empt");
        }

        //function to return to the main program or exit
        static void KeyFilter()
        {
            while (b3)
            {
                Console.Write("\n\tPress R to return to the main program. Press E to exit...");
                ConsoleKey K = Console.ReadKey().Key;
                if (K == ConsoleKey.R)
                {
                    Console.Clear();
                    b3 = false;
                    b1 = true;
                }
                if (K == ConsoleKey.E)
                {
                    b3 = false;
                    Environment.Exit(0);
                }
            }
        }
    }
}
