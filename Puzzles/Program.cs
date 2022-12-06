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

        static String TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
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
        
        static double TossMultipleCoins(int num)
        {
            double headCount = 0;
            double tailsCount = 0;
            double headToTailRatio = 0;

           for (int k = 0; k < num; k++)
            {
                String temp = TossCoin();
                if (temp == "Heads")
                {
                    headCount++;
                } else
                {
                    tailsCount++;
                }
            }

            Console.WriteLine("Getting ratio of heads to tails.");
            headToTailRatio = (headCount / tailsCount) * 100;
            headToTailRatio = Math.Round(headToTailRatio, 2);

            Console.WriteLine("You have flipped a coin {0} times.\nThe ratio of heads to tails is {1}.\nHeads: {2} and Tails: {3}"
                , num, headToTailRatio, headCount, tailsCount);

            return headToTailRatio;
        }

        static List<String> Names ()
        {
            Random rand = new Random();

            var namesList = new List<String>();
            namesList.Add("Todd");
            namesList.Add("Tiffany");
            namesList.Add("Charile");
            namesList.Add("Geneva");
            namesList.Add("Sydney");

            var suffledList = namesList.OrderBy(x => rand.Next()).ToList();

            
            var result = from n in suffledList
                         where n.Length > 5
                         select n;

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
            return namesList;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("CSharp Puzzles in progress..");
            Console.WriteLine("Random Array Test");
            RandomArray();

            Console.WriteLine("Toss Coin Test");
            Console.WriteLine(TossCoin());

            Console.WriteLine("Toss Multiple Coins Test");
            Console.WriteLine(TossMultipleCoins(100));

            Console.WriteLine("Names Test");
            Names();
        }
    }
}
