# Lab-03

## Introduction

### This Lab have bunch of exercises to learn more how C# work and use new built in function in some challenges , And how work with files Read and Write , And lean how test all edge case in this challenges , And learn how to use exception handling(Try ,catch)

------

## Challenge 1

### Problem analysis

> This program asks the user for 3 numbers, And return these 3 numbers multiplied together, If number less than 3 return 0, If puts more than 3 return first 3 number

### Edge case

- Input not number(FormatException) return 1 as default value

- Can it handle negative numbers

### Function structure

- Create public function

- Function return integer number

- Function with no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           Console.WriteLine(multiplied());
        }
```

- Console output

```bash
Please enter 3 numbers: 4 8 15
480
```

------

## Challenge 2

### Problem analysis

> Create a method that asks the user to enter a number between 2-10. Then, prompt the user that number of times for random numbers, And find average of all this random number

### Edge case

- User input negative numbers return 0

- Check if input real number

- If all number 0 return 0

### Function structure

- Create public function

- Function return integer number

- Function with no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           Console.WriteLine(average());
        }
```

- Console output

```bash
Please enter a number between 2-10: 5
1 of 5 - Enter a number: 12
2 of 5 - Enter a number: 34
3 of 5 - Enter a number: 2
4 of 5 - Enter a number: 13
5 of 5 - Enter a number: 1
Average = 5
```

------

## Challenge 3

### Problem analysis

> Console the following design

```bash
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
```

### Function structure

- Create public function

- Function void not return anything

- Function with no parameter

## Challenge 4

> Create method to find most number duplicates in array .

### Edge case

- If No duplicates exist in the array return first number

- All numbers in the array are the same value

- If more than number have same time duplicates return first found

### Function structure

- Create public function

- Function return integer number

- Function its take int array as parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            Console.WriteLine(duplicates(arr));
        }
```

- Console output

```bash
1
```

------

## Challenge 5

### Problem analysis

> Finds the maximum value in the array

### Edge case

- All array element have same number

- Empty Array

### Function structure

- Create public function

- Function return integer number

- Function its take int array as parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           
            int[] arr = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            Console.WriteLine(maxNum(arr));
        }
```

- Console output

```bash
555
```

------

## Challenge 6

### Problem analysis

> Write a method that asks the user to input a word in file.

### Edge case

- File not exists

### Function structure

- Create public function

- Function void not return anything

- Function take no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           WriteToFile();
        }
```

- Console output

```bash
Please Add Your Words
Hi form main function
```

> Create new txt file in root directory with user input text "Hi form main function"

------

## Challenge 7

### Problem analysis

> Write a method that reads all text in the file in from Challenge 6

### Edge case

- File not exists

### Function structure

- Create public function

- Function void not return anything

- Function take no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           ReadFromFile();
        }
```

- Console output

```bash
Welcome to Console Hi form main function
```

------

## Challenge 8

### Problem analysis

> Write a method user inpute new words and rewrites the words from Challenge 6 file

### Edge case

- File not exists

### Function structure

- Create public function

- Function void not return anything

- Function take no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           Rewrites();
        }
```

- Console output

```bash
Please add new world
Hi Console
```

> Words.txt have new word "Hi Console"

------

## Challenge 9

### Problem analysis

> Write a method that asks the user to input a sentence and returns an array that with the word and the number of characters each word has

```bash
Example: input: "This is a sentance about important things"
Output: ["this: 4","is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6"]
```

### Edge case

- Empty array

### Function structure

- Create public function

- Function return string array

- Function take no parameter

### Output

- Main Function

```C#
    static void Main(string[] args)
        {
           string[] sentences =  SentenceLength();
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.Write(sentences[i]);
            }
        }
```

- Console output

```bash
Please add your sentence
This is a sentance about important things
This:4 is:2 a:1 sentance:8 about:5 important:9 things:6
```