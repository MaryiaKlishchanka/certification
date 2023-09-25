﻿// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}

void PrintNumbers(int num)
{
    
    if (num == 0) return;
    System.Console.Write(num + " ");
    PrintNumbers(num-1);
}


int number = InputNum("введите число: ");
PrintNumbers(number);
