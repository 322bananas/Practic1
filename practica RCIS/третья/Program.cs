using System;
using System.IO;

namespace третья
{
    internal class Program
    {
        public static void Main(string[] args)
            /* Задание 1
            {
                string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\input3.txt";
                string[] lines = File.ReadAllLines(path);
                int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
                int n = int.Parse(lines[1]);
                string[] results = new string[n];
    
                for (int i = 0; i < n; i++)
                {
                    int[] ticketNumbers = lines[i].Split(' ').Select(int.Parse).ToArray();
                    int matchCount = ticketNumbers.Count(number => chosenNumbers.Contains(number));
                    results[i] = matchCount >= 3 ? "Lucky" : "Unlucky";
                }
    
                File.WriteAllLines("C:\\Users\\gr631_voavl\\Desktop\\Все практики\\1.3\\output.txt", results);
            */
            /* Задание 2
            {
                string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums3.txt";
                string[] chech = File.ReadAllText(path).Split(' ');
                int[] nums = new int[chech.Length];
    
                for (int i = 0; i < chech.Length; ++i)
                {
                    nums[i] = Convert.ToInt32(chech[i]);
    
                    if (nums[i] % 2 != 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            */

        /* Задание 3
        {
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums3Task.txt";
            using (StreamReader record = new StreamReader(path))
            {
                string line;

                while ((line = record.ReadLine()) != null)
                {
                    string[] read = line.Split(' ');
                    int[] height = new int[read.Length];

                    for (int i = 0; i < height.Length; i++)
                    {
                        height[i] = int.Parse(read[i]);
                    }

                    int output = 0;

                    for (int i = 0; i < height.Length; i++)
                    {
                        int max = 0;
                        int min = 999;

                        if (height[i] > max)
                        {
                            max = height[i];
                        }

                        if (height[i] < min)
                        {
                            min = height[i];
                        }

                        int difference = max - min;
                        max -= difference;
                        int[] value = new int[height.Length];

                        for (int j = 0; j < value.Length - 1; j++)
                        {
                            value[j] = max * min;

                            if (value[j] > value[j + 1])
                            {
                                output = value[j];
                            }
                        }
                    }

                    Console.WriteLine(output);
                }
            }
        }
        */
    }
}