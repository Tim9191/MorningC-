// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*
int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreatRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);


// Задайте двумерный массив размера m на n, каждый элемент в 
// массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.
*/


// Task 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j. 
// Выведите полученный массив на экран.

/*
int[,] FunctionArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = i + j;
    return array;
}
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter rows of array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns of array ");
int columns = Convert.ToInt32(Console.ReadLine());

Print2dArray(FunctionArray(rows, columns));
*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Enter raws of array ");
    int raws = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
Console.Write($"Sum of elements on main diagonal is {MainDiagonalSum(myArray)}");
*/



