using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        //Challenge 1
        static int Multiplied()
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
        static int Average()
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
                Console.Write($"{i+1} of {arr.Length} - Enter a number: ");
                try
                {
                   int inputNum = Convert.ToInt32(Console.ReadLine());
                   sum += num >= 0 ? num : 0 ;
                }
                catch(FormatException)
                {
                    sum += 0;
                }
            }
            avg = sum / arr.Length;
            Console.Write("Average = ");
            return avg;
        }

        //Challenge 3
        static void Stars()
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

        static int Duplicates(int[]arr)
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

        static int MaxNum(int [] arr)
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
        static void WriteToFile()
        {
            string path = "words.txt";
            String content = "";
            if (!File.Exists(path))
            {
                content = "Welcome to Words File ";
                File.WriteAllText(path, content);
            }
                Console.WriteLine("Please Add Your Words");
                content =" " + Console.ReadLine();
                File.AppendAllText(path, content);
        }

        //Challenge 7
        static void ReadFromFile()
        {
            String path = "words.txt";
            if (!File.Exists(path))
            { 
                WriteToFile();
            }
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }

        //Challenge 8

        static void Rewrites()
        {
            String path = "words.txt";
            if (!File.Exists(path))
            {
                WriteToFile();
            }
            Console.WriteLine("Please add new world");
            string content = Console.ReadLine();
            File.WriteAllText(path, content);
        }

        //Challenge 9

        static string[] SentenceLength()
        {
            Console.WriteLine("Please add your sentence ");
            string[] sentence = Console.ReadLine().Split(' ');
            for (int i = 0; i <  sentence.Length; i++)
            {
                sentence[i] = $"{sentence[i]}:{sentence[i].Length} ";
            }

            return sentence;
        }

        static void Main(string[] args)
        {

        }
    }
}
