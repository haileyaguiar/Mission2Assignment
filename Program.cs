using System;

namespace Mission2Assignment
{
    internal class Program
    {
        public static void Main()
        {
            //Intro message and prompt for input
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");

            //numRolls= whatever the user put (turned into an int)
            int numRolls = int.Parse(Console.ReadLine());

            //Create a RollDice object called diceSimulator
            RollDice diceSimulator = new RollDice();

            //Put the results into an array of integers called 'results' by calling the SimulateRolls method from the diceSimulator object
            int[] results = diceSimulator.SimulateRolls(numRolls);

            //ouptut messages
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

            //calling the DisplayResults method on the results array
            DisplayResults(results);

            //Goodbye!
            Console.WriteLine($"\nThank you for using the dice throwing simulator. Goodbye!");
        }

        //Creating the DisplayResults method
        private static void DisplayResults(int[] results)
        {
            //a totalRolls integer variable is the number of items in the results array
            int totalRolls = results.Length;

            //Write the message displaying the number of rolls found in the totalRolls variable
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            //initializing the for loop
            for (int i = 2; i <= 12; i++)
            {
                //calling the CountOccurrences method, passing in i and the results array
                int count = CountOccurrences(results, i);
                //Calculates the percentage
                int percentage = (count * 100) / totalRolls;

                //Adds a * for each percentage point
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }
        }

        //Creating the CountOccurrences method
        private static int CountOccurrences(int[] array, int value)
        {
            // A variable called count is set to 0
            int count = 0;

            //Looping through each element in the array passed to find the number of times the sum of the roll == each number
            foreach (int element in array)
            {
                if (element == value)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
