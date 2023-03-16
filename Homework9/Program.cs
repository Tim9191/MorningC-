// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

/*
void ShowNaturalNumbers(int num) 
{
    Console.Write(num + " ");
    if (num > 1)
        ShowNaturalNumbers(num - 1);
}

Console.Write("Enter a natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0) 
    ShowNaturalNumbers(num);
else
    Console.WriteLine(num +  "is not a natural number");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumOfNumbers(int m, int n) 
{
    if (m > n)
        return m + SumOfNumbers(m - 1, n);
    else if (m < n)
        return m + SumOfNumbers(m + 1, n);
    else    
        return n;    
}

Console.Write("Enter the natural number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the natural number n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n >0) 
{
    int sum = SumOfNumbers(m, n);
    Console.WriteLine($"The sum of natural numbers in the interval from {m} to {n}: {sum}");
} 

else 
{
    Console.WriteLine("The numbers m and n must be natural!");
} 
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return ackermann(m - 1, 1);
    else
        return ackermann(m - 1, ackermann(m, n - 1));       
}

int ackermannIterative(int m, int n)
{
    while (m != 0) 
    {
        if (n == 0)
             n = 1;
        else 
             n = ackermann(m, n - 1);
        m--;        
    }
    return n + 1;
}

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0 && m > 0) 
{ 
    int ackermannValue = ackermannIterative(m, n);
    Console.WriteLine($"A({m}, {n}) = {ackermannValue}");
} else 
{
    Console.WriteLine("M and N must not be negative.");
}
*/








