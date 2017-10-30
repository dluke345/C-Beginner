using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class WorkingWithFilesExercises
    {
        public void FileExercises()
        {
            //Write a program that reads a text file and displays the number of words.
            var path = @"C:\Users\David Luke\Desktop\test.txt";

            var content = File.ReadAllText(path);
            var count = 0;

            foreach (var c in content.Split(' '))
            {
                count++;
            }
            Console.WriteLine("There are '{0}' words in this text file.", count);

            //Write a porgram that reads a text file and displays the longest word in the file.
            var longestWord = "";

            foreach (var s in content.Split(' '))
            {
                if (s.Length > longestWord.Length)
                {
                    longestWord = s;
                }
            }
            Console.WriteLine("The longest word in this text file is '{0}'", longestWord);

        }
    }
}
