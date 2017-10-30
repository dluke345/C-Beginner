using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class WorkingWithFiles
    {
        public void Files()
        {
            //File provides static methods
            //If doing a small amount of work the File method is good
            var path = @"c:\someFile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            //FileInfo provides instance methods
            //If doing a large amount of work FileInfo method is better because static methods have security checking which can hinder performance
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }




            //Directory provides static methods
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            //Get all files in a specific path
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories =
                Directory.GetDirectories(@"c:\projects\CSharpFundaments", "*.*", SearchOption.AllDirectories);
            //Get all directories in a path
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");


            //Directory Info provides instance of methods
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();



            //Path
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension " + Path.GetExtension(path));
            Console.WriteLine("File Name " + Path.GetFileName(path));
            Console.WriteLine("File Name without extension " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name " + Path.GetDirectoryName(path));

        }
    }
}
