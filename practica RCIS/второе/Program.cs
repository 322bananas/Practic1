using System;
using System.Collections.Generic;

namespace второе
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Задание 1
                int[] array = new int[100];
                int a = 300;
                Console.WriteLine(a);
                
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = a - i * 3;
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.WriteLine(array[i + 1]);
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            */

            /* Задание 2
                int[] numbers = new int[100];
                int num = 1;
                
                for (int i = 1; i < numbers.Length; ++i)
                {
                    numbers[i] = num;
                    num += 2;
                }
                for (int i = 1; i < numbers.Length; ++i)
                {
                    Console.WriteLine(numbers[i]);
                }
            */
            /* Задание 3
                Console.Write("Введите кол-во строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введите кол-во столбцов: ");
                int columns = int.Parse(Console.ReadLine());
    
                int[,] matrix = new int[rows, columns];
    
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < columns; ++j)
                    {
                        matrix[0, j] = 1;
                        matrix[i, 0] = 1;
                        if (i > 0 & j > 0)
                        {
                            matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                        }
                    }
                }
    
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < columns; ++j)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            */

            /* Задание 4
    
                static int[] RandomAverage()
            {
                int[,] month = new int[12, 30];
                Random rnd = new Random();
                int[] sum = new int[12];
    
                for (int i = 0; i < 12; ++i)
                {
                    for (int j = 0; j < 30; ++j)
                    {
                        month[i, j] = rnd.Next(-30, 30);
                        sum[i] += month[i, j];
                    }    
                }
                return sum;
            }
    
            int[] average = RandomAverage();
            Console.WriteLine("Средння темпетарура по месяцам: ");
    
            for (int i = 0; i < average.Length; i++)
            {
                for (int j = 0; j < average.Length - i - 1; j++)
                {
                    if (average[j] > average[j + 1])
                    {
                        int temp = average[j];
                        average[j] = average[j + 1];
                        average[j + 1] = temp;
                    }
                }
            }
    
            for (int i = 0; i < average.Length; ++i)
            {
                Console.WriteLine($"{i + 1} = {average[i] / 30}");
            }
            */
            
        /* Задание 5

        static int[] RandomTemp()
        {
            Random rnd = new Random();
            int[] temp = new int[30];

            for (int i = 0; i < temp.Length; ++i)
            {
                temp[i] = rnd.Next(-30, 30);
        }
            return temp;
        }
        
        var month = new Dictionary<string, int[]>()
        {
            {"Январь", RandomTemp() },
            {"Февраль", RandomTemp()},
            {"Март", RandomTemp()},
            {"Апрель", RandomTemp()},
            {"Май", RandomTemp()},
            {"Июнь", RandomTemp()},
            {"Июль", RandomTemp()},
            {"Август", RandomTemp()},
            {"Сентябрь", RandomTemp()},
            {"Октябрь", RandomTemp()},
            {"Ноябрь", RandomTemp()},
            {"Декабрь", RandomTemp()},
        };
        foreach (var nameMonth in month)
        {
            Console.Write(nameMonth.Key + ": ");

        foreach (var temp in nameMonth.Value)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
        var Temp = new Dictionary<string, int>();

        foreach (var sumTemp in month)
        {
            int sum = 0;

            foreach (var nSum in sumTemp.Value)
            {
                sum += nSum;
            }

            int average = sum / 30;
            Temp.Add(sumTemp.Key, average);
        }

        Console.WriteLine("\nСреднняя температура по месяцам: ");

        List<KeyValuePair<string, int>> mappings = Temp.OrderBy(a => a.Value).ToList();
        Console.WriteLine(string.Join("\n", mappings));
        */
        }
    }
}