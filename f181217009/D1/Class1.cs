using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace D1
{
    public class Class1
    {
        public static void Generate(int arrSize, int minValue, int maxValue, string pathOutput)
        {
            StreamWriter File1 = new StreamWriter(pathOutput);
            Random r = new Random();
            int number = 0;

            for (int i = 0; i < arrSize; i++)
            {
                number = r.Next(minValue, maxValue + 1);
                File1.WriteLine(number);
            }
            File1.Flush();
            File1.Close();
        }
        public static void Sort(string pathOutput, string dirOutput)
        {
            StreamWriter File2 = new StreamWriter(dirOutput + "sorted.txt");
            string[] lines = File.ReadAllLines(pathOutput);
            int[] numbers = new int[lines.Length];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }
            QuickSort(numbers, 0, numbers.Length - 1);
            foreach (var number in numbers)
            {
                File2.WriteLine(number);
            }
            File2.Close();
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
        
    }
}
