using System;
using System.Linq;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static void randomArray()
        {
            Random rand = new Random();
            int[] array = new int[10];
            int max = array[0];
            int min = array[0];
            int sum = 0;
            for(int i= 0; i < array.Length; i++)
            {
                array[i] = rand.Next(5, 25);
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine("Sum is {0}, min is {1}, max is {2}", sum, min, max);
        }

        public static string coinFlip()
        {
            Random rand = new Random();

            Console.WriteLine("Tossing a coin");
            string[] headsTails = {"heads", "tails"};
            string result = headsTails[rand.Next(0,2)];
            Console.WriteLine(result);
            return result;
        }

        public static double multipleCoinFlip(int num)
        {
            Random rand = new Random();
            int totalTosses = 0;
            int totalHeads = 0;
            string[] headsTails = { "heads", "tails" };
            
            while(totalTosses < num)
            {
                string result = headsTails[rand.Next(0, 2)];
                if (result == "heads")
                {
                    totalHeads ++;
                }
                totalTosses ++;
            }
            double headsToTossesRatio = (double)totalHeads / (double)totalTosses;
            Console.WriteLine("Total Tosses: {0}, Total Heads {1}, Heads Ratio {2}", totalTosses, totalHeads, headsToTossesRatio);
            return headsToTossesRatio;

        }

        public static string[] Names()
        {
            Random rand = new Random();

            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] newNames = names.OrderBy(x => rand.Next()).ToArray();
            List<string> namesMoreThanFive = new List<string>();

            foreach (string n in newNames)
            {
                Console.WriteLine("{0} is the name, {1} is the name length", n, n.Length);
                if(n.Length > 5)
                {
                    namesMoreThanFive.Add(n);
                }
            }
            foreach (string n in namesMoreThanFive)
            {
                Console.WriteLine("names > 5 chars {0}", n);
            }    
            return namesMoreThanFive.ToArray();
        }

        static void Main(string[] args)
        {
            randomArray();
            coinFlip();
            multipleCoinFlip(137);
            Names();
        }
    }
}
