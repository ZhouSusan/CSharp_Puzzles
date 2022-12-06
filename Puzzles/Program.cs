using System;
using System.Collections.Generic;
using System.Collections;

namespace puzzles
{ 
    class Program
    {
        static int[] RandomArray()
        {
            int[] randomArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                randomArr[i] = rand.Next(5, 26);
            }

            int min = randomArr[0];
            int max = randomArr[0];
            int sum = randomArr[0];

            for (int j = 1; j < randomArr.Length; j++)
            {
                if (randomArr[j] < min)
                {
                    min = randomArr[j];
                }

                if (randomArr[j] > max)
                {
                    max = randomArr[j];
                }

                sum += randomArr[j];
            }

            Console.WriteLine("Min: {0}, Max: {1}, Sum:{2}", min, max, sum);
            return randomArr;
        }

        static String CoinToss()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 11);

            if (randNum < 6)
            {
                return "Heads";
            } else
            {
                return "Tails";
            }
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("CSharp Puzzles in progress..");
            Console.WriteLine("Random Array Test");
            RandomArray();

            Console.WriteLine("Coin Toss Test");
            Console.WriteLine(CoinToss());
        }
    }
}
