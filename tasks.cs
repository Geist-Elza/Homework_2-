/* Задача 1: Написать программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23. */

using System;
class Program
{
  static void Main() 
  {
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 7 == 0 && a % 23 == 0) 
    {
      Console.WriteLine("да");
    } 
    else 
    {
      Console.WriteLine("нет");
    }
  }
}

/* Задача 2: Написать программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка. */

using System;
class Program 
{    
  static void Main() 
  {
    Console.Write("Введите координаты точки X и Y через пробел:");
    string[] coordinates = Console.ReadLine().Split(' ');
    int x = Convert.ToInt32(coordinates[0]);
    int y = Convert.ToInt32(coordinates[1]);
    if (x > 0 && y > 0)
      Console.WriteLine("1");
    else if (x < 0 && y > 0)
      Console.WriteLine("2");
    else if (x < 0 && y < 0)
      Console.WriteLine("3");
    else if (x > 0 && y < 0)
      Console.WriteLine("4");
    else
      Console.WriteLine("Точка находится на оси координат");
  }
}

/* Задача 3: Написать программу, 
которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа. */

using System;
class Program
{    
  static void Main() 
  {
    Console.Write("Введите число из отрезка [10, 99]: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    Console.WriteLine(maxDigit);
  }
}

/* Задача 4: Написать программу, 
которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую. */

using System;
class Program 
{
  static void Main() 
  {
    Console.Write("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N < 10) 
    {
      Console.WriteLine(N);
    } 
    else 
    {
      while (N > 0) {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0) 
        {
          Console.Write(currentDigit + ",");
        } 
        else 
        {
          Console.WriteLine(currentDigit);
        }
      }
    }
  }
}
