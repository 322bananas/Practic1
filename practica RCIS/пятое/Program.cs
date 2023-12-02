using System;
using System.IO;

namespace пятое
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Задание 1
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums5Task1.txt";
            string[] numbers = File.ReadAllText(path).Split(' ');
            int[] nums = new int[numbers.Length];
            int min = int.Parse(numbers[0]);
            int index = 0;
            int result = 1;

            for (int i = 0; i < numbers.Length; ++i)
            {
                nums[i] = int.Parse(numbers[i]);
                if (min > nums[i])
                {
                    min = nums[i];
                    index = i;
                }
            }

            for (int i = index; i < numbers.Length; ++i)
            {
                result *= nums[i];
            }
            Console.WriteLine(result);
            */
            
            /* Задание 2
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums5Task2.txt";
            string[] numbers = File.ReadAllText(path).Split(';');
            float[] nums = new float[numbers.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = float.Parse(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int c = 0; c < numbers.Length - i - 1; c++)
                {
                    if (nums[c] > nums[c + 1])
                    {
                        float temp = nums[c];
                        nums[c] = nums[c + 1];
                        nums[c + 1] = temp;
                    }
                }
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            */
            
            /* Задание 3
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums5Task3.txt";
            string[] numbers = File.ReadAllText(path).Split(' ');
            int[] nums = new int[numbers.Length];
            int min = int.Parse(numbers[0]);
            int index = 0;
            float average = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                nums[i] = int.Parse(numbers[i]);

                if (min > nums[i])
                {
                    min = nums[i];
                    index = i;
                }
            }

            for (int i = 0; i < index; ++i)
            {
                average += nums[i];
            }
            average /= index;
            Console.WriteLine(average);
            */
            
            /* Задание 4
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums5Task4.txt";
            string[] numbers = File.ReadAllText(path).Split(' ');
            int[] nums = new int[numbers.Length];
            int max = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                nums[i] = int.Parse(numbers[i]);

                if (max < nums[i])
                {
                    max = nums[i];
                }
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                if (nums[i] == max - 1)
                {
                    sum += nums[i];
                }
            }

            Console.WriteLine(sum);
            */
            
            string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums5Task5.txt";
            string[] numbers = File.ReadAllText(path).Split(' ');
            int[] nums = new int[numbers.Length];
            int min = int.Parse(numbers[0]);
            int max = min;
            int indexMin = 0;
            int indexMax = 0;
            float average = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                nums[i] = int.Parse(numbers[i]);

                if (min > nums[i])
                {
                    min = nums[i];
                    indexMin = i;
                }

                if (max < nums[i])
                {
                    max = nums[i];
                    indexMax = i;
                }
            }

            for (int i = indexMin + 1; i < indexMax; ++i)
            {
                average += nums[i];
            }
            average /= indexMax - (indexMin + 1);
            Console.WriteLine(average);
        }
    }
}