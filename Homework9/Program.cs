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












