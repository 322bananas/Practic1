using System;
using System.Collections.Generic;

namespace первая
{
  internal class Program
  {
    static void Main(string[] args)
      /* Задание 1
      {
        int[] array = new int[10];
        Random random = new Random(); // Создал массив с рандомными числами
        
        for (int i = 0; i < 10; i++)
        {
          array[i] = random.Next(1, 100); // Через next ввёл диапазон выбора рандомных чисел
        }
        
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < 10; i++) // Создаю цикл для вывода наших рандомных чисел массива
        {
          Console.Write(array[i] + " "); 
        }
        Console.WriteLine();
  
        int minIndex = 0;
        for (int i = 1; i < 10; i++)
        {
          if (array[i] < array[minIndex])
          {
            minIndex = i;
          }
        }
        Console.WriteLine($"Номер минимального элемента: {minIndex}");
      }
      */

      /* Задание 2
       {
        List<int> numbers = new List<int>(); // Создание пустого списка
        
        int input;
        do
        {
          Console.Write("Введите число (для завершения программы введите 0): ");
          input = Convert.ToInt32(Console.ReadLine());
          if (input != 0)
          {
            numbers.Add(input);
          }
        } while (input != 0);
  
        int sum = 0;
        int composition = 1;
        foreach (int number in numbers)
        {
          sum += number;
          composition *= number;
        }
  
        double average = (double)sum / numbers.Count;
        
        Console.WriteLine("Сумма всех элементов списка: " + sum);
        Console.WriteLine("Произведение всех элементов списка: " + composition);
        Console.WriteLine("Среднее значение всех элементов списка: " + average);
      }
      */

      /* Задание 3
      {
        List<string> words = new List<string>();
  
        string input;
        do
        {
          Console.Write("Введите число (для завершения программы введите пустую строку): ");
          input = Console.ReadLine();
          if (!string.IsNullOrWhiteSpace(input))
          {
            words.Add(input);
          }
        } 
        while (!string.IsNullOrWhiteSpace(input));
        
        string min = null;
        string max = null;
        
        foreach (string word in words)
        {
          if (min == null || word.Length < min.Length)
          {
            min = word;
          }
          else if (max == null || word.Length > max.Length)
          {
            max = word;
          }
        }
        Console.WriteLine($"Самый короткий элемент списка: {min}");
        Console.WriteLine($"Самый длинный элемент списка: {max}");
      }
      */
    
      /* Задание 4
      {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Введите начальное число диапазона: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Введите конечное число диапазона: ");
        int end = int.Parse(Console.ReadLine());

        int[] numbers = GenerateRandomArray(size, start, end);
        foreach (int num in numbers)
        {
          Console.Write(num + "\t");
        }
      }

      static int[] GenerateRandomArray(int size, int start, int end)
      {
        Random rnd = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; ++i)
        {
          numbers[i] = rnd.Next(start, end + 1);
        }
        return numbers;
      }
      */

      /* Задание 5
      {
        Console.Write("Введите строку: ");
        string word = Console.ReadLine();
  
        string[] wordCount = word.Split( ' ');
        string endstart = "Start " + word + " End";
    
        Console.WriteLine("Количество слов: " + wordCount.Length);
        Console.WriteLine("Изменённая строка: " + endstart);
      }
      */
  }
}