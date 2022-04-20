using System;

namespace HomeWork1
{
    class Program
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | odd                                  |
          * |--------|--------------------------------------|
          * |  2     | even                                 |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            //your code here
            if (number % 2 == 0 && number > 0)
            {
                Console.WriteLine(number + " is an even integer" );
            }
            else if (number < 0) 
            { 
                Console.WriteLine(number + " the value should be greater then zero");
            }

            else 
            { 
                Console.WriteLine(number + " is an odd integer");
            }

        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
     
            string res = number % 4 == 0 ? "The number " + number + " divide to 4 " : "The number " + number + " doesn't divide to 4";
            Console.WriteLine(res);
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                case "Monday": Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                case "Wednesday":
                    Console.WriteLine("3");
                    break;
                case "Thursday":
                    Console.WriteLine("4");
                    break;
                case "Friday":
                    Console.WriteLine("5");
                    break;
                case "Saturday":
                    Console.WriteLine("6");
                    break;
                case "Sunday":
                    Console.WriteLine("7");
                    break;
                default: Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //your code here

            //method 1 
            switch (character)
            {
                case 'a':
                    Console.WriteLine(character + " is a vowel");
                    break;
                case 'i':
                    Console.WriteLine(character + " is a vowel");
                    break;
                case 'o':
                    Console.WriteLine(character + " is a vowel");
                    break;
                case 'u':
                    Console.WriteLine(character + " is a vowel ");
                    break;
                case 'e':
                    Console.WriteLine(character + " is a vowel ");
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine(character + " is not a letter ");
                    break;
                default:
                    Console.WriteLine(character + " is a consonant");
                    break;
            }

            //method 2
            
            int i = Convert.ToChar(character);
            if (character == 'a' || character == 'e' || character == 'i' ||
                         character == 'o' || character == 'u') 
            {
                Console.WriteLine(character + " is a vowel ");
            }

            else if (i >= 33 && i <= 64)
            {
                Console.WriteLine(character + " is not a letter");
            }

            else 
            {
                Console.WriteLine(character + " is a consonant");
            }
                

        }
        public static void Main(String[] args)
        {
            Program homework = new Program();
            Console.WriteLine("\n----------Greater then zero and even or odd");
            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            Console.WriteLine("\n----------Divide to 4");
            homework.NumberDivideToFour(10);
             homework.NumberDivideToFour(16);
            //---------------------------------------
            Console.WriteLine("\n----------Number of the day");
            homework.DayOfWeek("Monday");
             homework.DayOfWeek("Sunday");
             homework.DayOfWeek("some day");

            //---------------------------------------
            Console.WriteLine("\n----------Check vowel letter");
            homework.CheckLetterIfVowel('p');
             homework.CheckLetterIfVowel('i');
            homework.CheckLetterIfVowel('1');

        }
    }
}


