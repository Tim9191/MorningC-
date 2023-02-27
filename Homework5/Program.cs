// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenNumberArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)    
        if(array[i] % 2 == 0) result++;
    return result;
}

Console.Write("Enter a quantity of elelements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, 100, 999);
ShowArray(newArray);
int num = EvenNumberArray(newArray);
Console.WriteLine($"There are {num} even numbers in the new array");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumofRandomOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;    
}

Console.Write("Enter a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimal possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximal possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, minValue, maxValue);
ShowArray(newArray);

int sum = SumofRandomOddNumbers(newArray);
Console.WriteLine($"The sum of the odd indexes is: {sum}");
*/



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
int DifferencebetweenMaxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
ShowArray(newArray);

int diff = DifferencebetweenMaxAndMin(newArray);
Console.WriteLine("Show the difference between the max element and min element: " +diff);
*/


