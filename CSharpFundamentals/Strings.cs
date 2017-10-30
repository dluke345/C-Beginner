using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Strings
    {

        public void strings()
        {
            var fullname = "David Luke ";

            //Trim - removes white space
            Console.WriteLine("Trim: '{0}'", fullname.Trim());

            //ToUpper
            Console.WriteLine("ToUpper: {0}", fullname.Trim().ToUpper());

            //SubString and IndexOf
            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine(firstName + " " + lastName);

            //Split
            var names = fullname.Split(' ');
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Lastname: " + names[1]);

            //Replace
            var newName = fullname.Replace("David", "Poop");
            Console.WriteLine("Replace: " + newName);

            //If Null Or Empty
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }

            //Is Null Or White Space
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            //Convert
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));


            //******************String Builder*********************
            //This is immuntable so you can change the string on the fly without creating another instance of object
            //You cannot search through text in stringBuilder - DownSide
            //Can chain these methods
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First character: " + builder[0]);



            //*************Summarising Text*******************
            var sentence = "This is going to be a really really really really really long text.";
            var summary = SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        //Clean reusable method
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }
                return String.Join(" ", summaryWords) + "..."; ;
            }
        }

    }
}
