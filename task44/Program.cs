﻿// не используя рекурсию выведите первые N чисел Фиббоначи.
//  Первые два числа 0 и 1

bool Validation(int a)
{
    return a > 2;
}

int[] FibonacciArray(int a)
{
    int[] arr = new int[a];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < a; i++)
    {
        checked
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Введите число больше 2: ");
int number = Convert.ToInt32(Console.ReadLine());

while (!Validation(number))
{
    Console.WriteLine("Введите число больше 2: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int[] fibonacciArray = FibonacciArray(number);
PrintArray(fibonacciArray);


