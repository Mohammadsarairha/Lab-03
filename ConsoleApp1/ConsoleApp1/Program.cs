using System;

namespace ConsoleApp1
{
    internal class Program
    {
        //Challenge 1
        static int multiplied()
        {
            int[] num = new int [3];
            int result=1;
            Console.Write("Please enter 3 numbers: ");
            string[] inputNumbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < num.Length; i++)
            {
                try
                {
                    num[i] = Convert.ToInt32(inputNumbers[i]);
                }
                catch(FormatException)
                {
                    num[i] = 1;
                }catch (IndexOutOfRangeException)
                {
                    return 222;
                }

                result *= num[i];
            }
            return result;
        }

        //Challenge 2
        static int average()
        {
            int num = 0;
            
            while (num < 2 || num > 10)
            {

                Console.Write("Please enter a number between 2-10: ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    continue;
                }
            }

            int [] arr = new int [num];
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i+1} of {arr.Length} - Enter a number:");
                try
                {
                    sum += Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    sum += 0;
                }
            }
            avg = sum / arr.Length;
            return avg;
        }

        //Challenge 3
        static void stars()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 5 - 1; i >= 1; i--)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //Challenge 4

        static int duplicates(int[]arr)
        {
            int repeat = 0;
            int maxRepeat = 0;
            int maxNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        repeat++;
                    }
                }
                if (repeat > maxRepeat)
                {
                    maxRepeat = repeat;
                    maxNum = arr[i];
                }
                repeat = 0;
            }
            return maxNum;
        }

        //Challenge 5

        static int maxNum(int [] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }

        //Challenge 6



        static void Main(string[] args)
        {

        }
    }
}
