using System;
using System.IO;

namespace четвёртая
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        /* Задание 1
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());
        int product = 1;

        for (int i = 3; i <= n; ++i)
        {   
            if (i % 3 == 0) 
            {
                product *= i;
            }
        }
        Console.WriteLine(product);
        */

        /* Задание 2
        string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums4Task2.txt";
        string[] numbers = File.ReadAllText(path).Split(';');
        float[] nums = new float[numbers.Length];
        float sum = 0;

        for (int i = 0; i < numbers.Length; ++i)
        {
            nums[i] = float.Parse(numbers[i]);
            if (nums[i] > 0)
            {
                sum += nums[i];
            }
        }
        Console.WriteLine(sum);
        */
        
        /* Задание 3
        string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums4Task3.txt";
        string[] numbers = File.ReadAllText(path).Split(',');
        int[] nums = new int[numbers.Length];
        int min = int.Parse(numbers[0]);
        int max = min;
        for (int i = 0; i < numbers.Length; ++i)
        {
            nums[i] = int.Parse(numbers[i]);
            if (min > nums[i])
            {
                min = nums[i];
            }
            if (max < nums[i])
            {
                max = nums[i];
            }
        }
        Console.WriteLine(min +" < "+ max);
        */
        
        /* Задание 4
        string path = @"C:\Users\volos\OneDrive\Рабочий стол\Git\\nums4Task4.txt";
        string[] numbers = File.ReadAllText(path).Split(' ');
        int count = 0;

        for (int i = 1; i < numbers.Length; ++i)
        {
            if (numbers[i] == numbers[i - 1])
            {
                count++;
            }
        }
        Console.WriteLine(count);
        */
    }
  }
}