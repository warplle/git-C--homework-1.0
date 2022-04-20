
namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
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

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The " + number + " you entered is even");
                }
                else
                {
                    Console.WriteLine("The " + number + " you entered is odd");
                }
            }
            else
            {
                Console.WriteLine("The " + number + " number is lower than 0!");
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
            var result = number % 4 == 0 ? "The " + number + " was divided to 4 without rest" : "The " + number + " was not divided to 4 without rest";
            Console.WriteLine(result);
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

            string numberOfTheDay;
            switch (day)
            {
                case "Monday":
                    numberOfTheDay = "1";
                    break;
                case "Tuesday":
                    numberOfTheDay = "2";
                    break;
                case "Wednesday":
                    numberOfTheDay = "3";
                    break;
                case "Thursday":
                    numberOfTheDay = "4";
                    break;
                case "Friday":
                    numberOfTheDay = "5";
                    break;
                case "Saturday":
                    numberOfTheDay = "6";
                    break;
                case "Sunday":
                    numberOfTheDay = "7";
                    break;
                default:
                    numberOfTheDay = "Wrong value! Please give a day of a week ";
                    break;
            }
            Console.WriteLine("The number of the day of " + day + " is: " + numberOfTheDay);
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

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("The entered character " + character + " is a vowel");
            }
            else if (character == 'b' ||character == 'c' ||character == 'd' ||character == 'f' ||character == 'g' ||character == 'h'
                 ||character == 'j' ||character == 'k' ||character == 'l' ||character == 'm' ||character == 'n' ||character == 'p'
                 ||character == 'q' ||character == 'r' ||character == 's' ||character == 't' ||character == 'v' ||character == 'x'
                 ||character == 'z')
            {
                Console.WriteLine("The entered character " + character + " is a consonant");
            }
            else
            {
                Console.WriteLine("The entered character " + character + " is not a letter");
            }

        }

        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);

            ////---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);

            ////---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");

            ////---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');
            homework.CheckLetterIfVowel('u');
            homework.CheckLetterIfVowel('@');
            homework.CheckLetterIfVowel('&');
        }
    }
}
