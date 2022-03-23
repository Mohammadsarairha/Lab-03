using System;
using System.IO;

namespace Lab03_App
{
    public class Program
    {
        //Challenge 1
        static void Multiplied()
        {
            Console.Write("Please enter 3 numbers: ");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            int MultipliedResult = MultipliedNumbers(inputNumbers);
            Console.WriteLine(MultipliedResult);
        }

        public static int MultipliedNumbers(string [] inputNumbers)
        {
            int[] num = new int[3];
            int result = 1;
            for (int i = 0; i < num.Length; i++)
            {
                try
                {
                    num[i] = Convert.ToInt32(inputNumbers[i]);
                }
                catch (FormatException)
                {
                    num[i] = 1;
                }
                catch (IndexOutOfRangeException)
                {
                    return 0;
                }

                result *= num[i];
            }
            return result;
        }

        //Challenge 2
        static void AverageInput()
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

            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1} of {arr.Length} - Enter a number: ");
                try
                {
                    int inputNum = Convert.ToInt32(Console.ReadLine());
                    arr[i]= inputNum >= 0 ? inputNum : 0;
                }
                catch (FormatException)
                {
                    arr[i]= 0;
                }
            }
            Console.Write($"Average = {AverageNumber(arr)}");
            
        }

        public static int AverageNumber(int [] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum == 0)
            {
                return 0;
            }
            else
            {
                return sum / arr.Length;
            }
        }

        //Challenge 3
        public static void Stars()
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
        public static int Duplicates(int[] arr)
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
            if (repeat == 0)
            {
                return arr[0];
            }
            return maxNum;
        }

        //Challenge 5
        public static int MaxNum(int[] arr)
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
        public static void WriteToFile()
        {
            string path = "words.txt";
            String content = "";
            if (!File.Exists(path))
            {
                content = "Welcome to Words File ";
                File.WriteAllText(path, content);
            }
            Console.WriteLine("Please Add Your Words");
            content = " " + Console.ReadLine();
            File.AppendAllText(path, content);
        }

        //Challenge 7
        public static void ReadFromFile()
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
        public static void Rewrites()
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
        public static void SentenceLength()
        {
            Console.WriteLine("Please add your sentence ");
            string sentence = Console.ReadLine();
            string[] sentenceNum = SentenceSplit(sentence);
            for (int i = 0; i < sentenceNum.Length; i++)
            {
                Console.Write(sentenceNum[i]);
            }
        }

        public static string[] SentenceSplit(string sentence)
        {
            string[] sentenceArray = sentence.Split(' ');

            for (int i = 0; i < sentenceArray.Length; i++)
            {
                sentenceArray[i] = $"{sentenceArray[i]}: {sentenceArray[i].Length}";
            }

            return sentenceArray;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
