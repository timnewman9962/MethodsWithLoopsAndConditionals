using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Print2000Integers()
        {
            Console.WriteLine("Printing all integers from 1000 to -1000:");
            var n = 1000;
            var nMax = -1000;
            var maxNums = 10;
            var line = "";
            while(n >= nMax)
            {
                for (int i = 0; i < maxNums && n >= nMax; i++)
                    line += $"{n--} ";
                Console.WriteLine(line);
                line = "";
            }
        }

        static void Print3to999by3s()
        {
            Console.WriteLine("Printing all integers from 3 to 999 by 3's:");
            var n = 1;
            var nMax = 999 / 3;
            var maxNums = 9;
            var line = "";
            while (n <= nMax)
            {
                for (int i = 0; i < maxNums && n <= nMax; i++)
                    line += $"{3 * n++} ";
                Console.WriteLine(line);
                line = "";
            }
        }

        static int AskForInput(string prompt)
        {
            int n;
            Console.WriteLine(prompt);
            while (!Int32.TryParse(Console.ReadLine(), out n))
                Console.WriteLine($"Conversion to integer failed. Please try again...");
            return n;
        }

        static bool IsEqual(int a, int b)
        {
            Console.WriteLine($"Printing if {a} equals {b}:");
            Console.WriteLine(a == b);
            return a == b;
        }

        static bool IsEven(int a)
        {
            Console.WriteLine($"Printing if {a} is even:");
            Console.WriteLine(a % 2 == 0);
            return a % 2 == 0;
        }

        static bool IsPositive(int a)
        {
            Console.WriteLine($"Printing if {a} is positive:");
            Console.WriteLine(a >= 0);
            return a >= 0;
        }

        static bool CanVote(int a)
        {
            Console.WriteLine($"Printing if {a} is an age eligible to vote:");
            Console.WriteLine(a >= 18);
            return a >= 18;
        }

        static bool IsRangePosNegTen(int a)
        {
            Console.WriteLine($"Printing if {a} is the range of +/- 10:");
            Console.WriteLine(a >= -10 && a <= 10);
            return a >= -10 && a <= 10;
        }

        static void TimesTables(int a)
        {
            Console.WriteLine($"Printing the multiplication table of {a} (from 1 to 12):");
            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"{a} x {i} = {a * i}");
        }

        static int[] MakeIntArray(int a)
        {
            Console.WriteLine($"Making an array of {a} random values");
            var rtn = new int[a];
            var rand = new Random();
            for(int i = 0; i < a; i++)
                rtn[i] = rand.Next(1001);
            return rtn;
        }

        static int ArraySum(int[] a)
        {
            Console.WriteLine($"Finding the sum of the {a.Length} values in the array:");
            var nSum = 0;
            foreach (int n in a)
                nSum += n;
            Console.WriteLine(nSum);
            return nSum;
        }

        static void Cubes(int a)
        {
            Console.WriteLine($"Finding the cubes up to {a}:");
            if (a == 0)
                return;
            var nCnt = 1;
            do
                Console.WriteLine($"Number is: {nCnt} and the cube of {nCnt} is: {nCnt * nCnt * nCnt}");
            while (nCnt++ <= a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\n************************");
            Console.WriteLine("Section \"Luke Warm\"");
            Console.WriteLine("************************\n");

            Print2000Integers();
            Console.WriteLine("------------------\n");
            
            Print3to999by3s();
            Console.WriteLine("------------------\n");
            
            int numsForEqual_1 = AskForInput("Please enter a number:");
            int numsForEqual_2 = AskForInput("Please enter another one for comparison:");
            IsEqual(numsForEqual_1, numsForEqual_2);
            Console.WriteLine("------------------\n");
            
            IsEven(numsForEqual_1);
            IsEven(numsForEqual_2);
            Console.WriteLine("------------------\n");
            
            IsPositive(numsForEqual_1);
            IsPositive(numsForEqual_2);
            Console.WriteLine("------------------\n");
            
            int nVoteAge = AskForInput("Now input someone's age");
            CanVote(nVoteAge);
            Console.WriteLine("------------------\n");

            Console.WriteLine("\n************************");
            Console.WriteLine("Section \"Heatin Up\"");
            Console.WriteLine("************************\n");

            int finalNum = AskForInput("Input a number for the remainder of the methods:");
            IsRangePosNegTen(finalNum);
            Console.WriteLine("------------------\n");
            
            TimesTables(finalNum);
            Console.WriteLine("------------------\n");
            
            finalNum *= finalNum < 0 ? -1 : 1;
            int[] myArray = MakeIntArray(finalNum);
            foreach (int i in myArray)
                Console.WriteLine(i);
            Console.WriteLine("------------------\n");
            
            ArraySum(myArray);
            Console.WriteLine("------------------\n");
            
            Cubes(finalNum);
            Console.WriteLine("------------------\n");
        }
    }
}
