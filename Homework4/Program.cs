// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {    
        Console.Write($"Enter the {i+1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Enter size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size);
ShowArray(newArray);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += (num % 10);
        num /= 10;
    }
    return sum;
}

Console.Write("Enter an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(num);
Console.WriteLine("The sum of the digits is: " + result);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double exponent(double A, int B)
{
    double result = 1;

    for (int i = 1; i <= B; i++)
    {
        result *= A;
    } 
    return result;
}


Console.Write("Enter the number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the number B: ");
int B = Convert.ToInt32(Console.ReadLine());
double result = exponent(A, B);

Console.WriteLine("The number A to the power number B is: " + result);
*/












