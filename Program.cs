﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void Recursion(int MinNumber, int MaxNumber)
{
    if (MaxNumber >= MinNumber)
    {
        Recursion(MinNumber, MaxNumber - 1);
        Console.Write($"{MaxNumber} ");
    }
}

Console.Write("Введите начальное число для рекурсии: ");
int inputMin = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число для рекурсии: ");
int inputMax = int.Parse(Console.ReadLine()!);
Recursion(inputMin, inputMax);



﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

AkkermanFunction(m, n);


void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


    
int[] myArray = { 1, 2, 5, 0, 25,47 };
    {
         PrintArrayFromEnd(myArray, myArray.Length - 1);
    }

     static void PrintArrayFromEnd(int[] arr, int index)
    {
         if (index >= 0)
         {
             Console.WriteLine(arr[index]);
             PrintArrayFromEnd(arr, index - 1);
         }
    }