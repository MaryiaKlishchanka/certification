// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}

int FunctionA(int m, int n)
{
    if(m==0) return n+1;
    else if(n==0 && m>0) return FunctionA(m-1, 1);
    else return FunctionA(m-1, FunctionA(m, n-1));
}
int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");
int akker = FunctionA(first, second);
Console.WriteLine(akker);