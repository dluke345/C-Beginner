using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class StringExercises
    {
        public void StringExercise()
        {
            //String Exercises
            //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            Console.WriteLine("Enter numbers separated by a hyphen to check for consecutive numbers");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                var result = CheckConsecutiveNumbers(input);
                Console.WriteLine(result);
            }




            //Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses enter, without supplying and input, exit immediatley.
            //Otherwise check to see if there are duplicates, if so display duplicate
            Console.WriteLine("Enter numbers separated by a hyphen to check for duplicates");
            var input2 = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input2))
            {
                var result2 = CheckForDuplicates(input2);
                Console.WriteLine(result2);
            }

            //Write a program and ask the user to enter a time value, valid time should be between 00:00 and 23:59. If the time is valid display "Ok" otherwise display "Invalid Time"
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            var input3 = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input3))
            {
                var result3 = CheckForValidTime(input3);
                Console.WriteLine(result3);
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

            //Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. 
            Console.WriteLine("Enter a few words separated by a space to see it in PascalCase");
            var input4 = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input4))
            {
                var result4 = ConvertTextToPascalCase(input4);
                Console.WriteLine(result4);
            }


            //Write a program and ask the user to enter an English word. Count the number of vowels(a, e, o, u, i) in the word.
            Console.WriteLine("Enter an english word and I will tell you have many vowels are in it.");
            var input5 = Console.ReadLine();
            var result5 = CountVowels(input5);

            Console.WriteLine(result5);
        }

        public static string CheckConsecutiveNumbers(string numbers)
        {
            var numbers1 = new List<int>();
            foreach (var number in numbers.Split('-'))
            {
                numbers1.Add(Convert.ToInt32(number));
            }

            numbers1.Sort();
            var isConsecutive = true;

            for (var i = 1; i < numbers1.Count; i++)
            {
                if (numbers1[i] != numbers1[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            return isConsecutive ? "Consecutive" : "Not Consecutive";

        }

        public static string CheckForDuplicates(string numbers)
        {
            var numbers2 = new List<int>();

            foreach (var s in numbers.Split('-'))
            {
                numbers2.Add(Convert.ToInt32(s));
            }

            numbers2.Sort();
            var includesDuplicate = false;
            var uniqueNums = new List<int>();

            foreach (var n in numbers2)
            {
                if (!uniqueNums.Contains(n))
                {
                    uniqueNums.Add(n);
                }
                else
                {
                    includesDuplicate = true;
                    break;
                }
            }

            return includesDuplicate ? "Duplicate" : "No Duplicates";

        }

        public static string CheckForValidTime(string time)
        {
            var array = time.Split(':');
            var firstNum = Convert.ToInt32(array[0]);
            var secondNum = Convert.ToInt32(array[1]);
            var isValid = false;

            if (firstNum <= 23 && firstNum >= 00 && secondNum <= 59 && secondNum >= 00)
            {
                isValid = true;
            }

            return isValid ? "Ok" : "Invalid Time";
        }

        public static string ConvertTextToPascalCase(string text)
        {
            var array2 = text.Split(' ');
            var result4 = "";

            foreach (var s in array2)
            {
                var pascalCase = s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1).ToLower();
                result4 += pascalCase;
            }

            return result4;
        }

        public static string CountVowels(string text)
        {
            int count = 0;

            foreach (var c in text)
            {
                if (c == 'a' || c == 'i' || c == 'u' || c == 'o' || c == 'e')
                {
                    count++;
                }
            }

            return count.ToString();
        }

    }
}
