using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Generate a file -gt");
            Console.WriteLine("2.Sort a file -st");
            Console.WriteLine("3.View the files -vt");
            Console.WriteLine("4.exit");
            Console.WriteLine("Your command:");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                if (input == "-gt")
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "TextFile.exe";
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.StartInfo.Arguments = "-gt";
                    myProcess.Start();
                    myProcess.WaitForExit();
                    Console.WriteLine("A file was generated");
                }
                if (input == "-st")
                {
                    if (!File.Exists(@"C:\Users\Freeware Sys\Documents\Visual Studio 2015\Projects\f181217009\Interface\bin\Debug\generated.txt"))
                    {

                        Console.WriteLine("Please generate a file first");
                    }
                    else {
                        Process myProcess = new Process();
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.FileName = "TextFile.exe";
                        myProcess.StartInfo.CreateNoWindow = false;
                        myProcess.StartInfo.Arguments = "-st";
                        myProcess.Start();
                        myProcess.WaitForExit();
                        Console.WriteLine("The file was sorted");
                    }
                }
                if (input == "-vt")
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "TextFile.exe";
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.StartInfo.Arguments = "-vt";
                    myProcess.Start();
                    myProcess.WaitForExit();
                }
                else if (input != "-gt" & input != "-st" & input != "-vt") 
                {
                    Console.WriteLine("Invalid command:");
                }
                Console.WriteLine("Your next command:");
                input = Console.ReadLine();
            }
        }
    }
}
