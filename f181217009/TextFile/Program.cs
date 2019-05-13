using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using D1;
using System.Net;
using System.Net.Sockets;

namespace TextFile
{
    public class Program
    {

        static void View(string pathOutput, string dirOutput)
        {

            string[] unsorted = File.ReadAllLines(pathOutput);
            string[] sorted = File.ReadAllLines(dirOutput + "sorted.txt");
            Console.WriteLine("unsorted: " + "sorted: ");
            for (int i = 0; i <= unsorted.Length - 1; i++)
            {
                if (int.Parse(unsorted[i]) < 10)
                {
                    Console.WriteLine("{0} " + "            " + "{1}", unsorted[i], sorted[i]);
                }
                else if (int.Parse(unsorted[i]) > 100)
                {
                    Console.WriteLine("{0} " + "          " + "{1}", unsorted[i], sorted[i]);
                }
                else {
                    Console.WriteLine("{0} " + "           " + "{1}", unsorted[i], sorted[i]);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            string pathOutput = "1";
            string dirOutput = "1";
            if (File.Exists(Directory.GetCurrentDirectory()+@"\pathOutput.txt"))
            {
                StreamReader sr = new StreamReader("pathOutput.txt");
                pathOutput = sr.ReadLine();
                sr.Close();
                StreamReader dr = new StreamReader("dirOutput.txt");
                dirOutput = dr.ReadLine();
                dr.Close();
                if (args[0] == "-g")
                {
                    D1.Class1.Generate(int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]), pathOutput);
                }
                if (args[0] == "-s")
                {
                    D1.Class1.Sort(pathOutput, dirOutput);
                }
                if (args[0] == "-v")
                {
                    View(pathOutput, dirOutput);
                }
            }
            if (args[0] == "-gt")
            {
                D1.Class1.Generate(100, 0, 99, Directory.GetCurrentDirectory()+@"\generated.txt");
            }
            if (args[0] == "-st")
            {
                D1.Class1.Sort(Directory.GetCurrentDirectory() + @"\generated.txt", Directory.GetCurrentDirectory() + @"\");
            }
            if (args[0] == "-vt")
            {
                View(Directory.GetCurrentDirectory() + @"\generated.txt", Directory.GetCurrentDirectory() + @"\");
            }
        }
    }
}
