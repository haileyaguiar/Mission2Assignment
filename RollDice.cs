using System;

namespace Mission2Assignment
{
    //Creating the RollDice class
    internal class RollDice
    {
        //Creating the SimulateRolls method 
        public int[] SimulateRolls(int numRolls)
        {
            //creating the results array with the length of the numRolls
            int[] results = new int[numRolls];

            //creating a new random object called random
            Random random = new Random();

            //Executing this loop the amount of times numRolls is
            for (int i = 0; i < numRolls; i++)
            {
                //Getting a random number for each dice between 1 and 6
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                //adding the two random numbers together
                int sum = dice1 + dice2;

                //storing the sum in the results array at position i
                results[i] = sum;
            }

            //sending back the results array
            return results;
        }
    }
}

