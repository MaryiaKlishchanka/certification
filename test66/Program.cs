// Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}

int SumNumbers(int m, int n)
{
    
    if (m>n) return 0;
    else if (m==n) return n;
    else return n + SumNumbers(m, --n);
}


int start = InputNum("введите число M: ");
int end = InputNum("введите число N: ");
int sum = SumNumbers(start, end);
Console.WriteLine(sum);

