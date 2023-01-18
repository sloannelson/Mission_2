using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    class SixSideDice
    {

        static void Main()

        {
            int[] DiceTotal = new int[13];
            Random rnd = new Random();

            Console.WriteLine("How many times do you want to roll the dice?");
            int numRolls = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRolls; i++)
            {
                int Dice1 = rnd.Next(1, 7);
                int Dice2 = rnd.Next(1, 7);
                int D1D2 = Dice1 + Dice2;
                DiceTotal[D1D2]++;
            }

            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");
                int percentage = (int)(((double)DiceTotal[i] / numRolls) * 100);
                for (int j = 0; j < percentage; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for using the simulator. Goodbye!");


    }
    }
}