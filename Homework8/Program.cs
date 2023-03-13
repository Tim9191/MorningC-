// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
using System;


int[,] array = new int[4, 5];
Random rnd = new Random();

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = 0; k < array.GetLength(1); k++)
        {
            if(array[i, j] > array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
Console.WriteLine("\n\n");

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
using System;


int[,] array = new int[4, 5];
int[] sumArray = new int[array.GetLength(0)];
Random rnd = new Random();

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(0, 10);
        sumArray[i] += array[i, j];
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(" / " + sumArray[i]);
}

int min = sumArray[0];
int minIndex = 0;

for(int i = 0; i < sumArray.Length; i++)
{
    if(sumArray[i] < min)
    {
        min = sumArray[i];
        minIndex = i;
    }
}


Console.WriteLine("\nLine with lowest sum: ");

for(int i = 0; i < array.GetLength(1); i++)
{
    Console.Write(array[minIndex, i] + " ");
}
Console.WriteLine();
*/



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


/*
using System;


int[,] matrixA = new int[3, 3];
int[,] matrixB = new int[3, 3];
int[,] matrixResult = new int[3, 3];

Random rnd = new Random();


Console.WriteLine("Matrix A: ");
for(int i = 0; i < matrixA.GetLength(0); i++)
{
    for(int j = 0; j < matrixA.GetLength(1); j++)
    {
        matrixA[i, j] = rnd.Next(0, 10);
        Console.Write(matrixA[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nMatrix B: ");
for(int i = 0; i < matrixB.GetLength(0); i++)
{
    for(int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixB[i, j] = rnd.Next(0, 10);
        Console.Write(matrixB[i, j] + " ");
    }
    Console.WriteLine();
}


for(int i = 0; i < matrixA.GetLength(0); i++)
{
    for(int j = 0; j < matrixB.GetLength(1); j++)
    {
        for(int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

Console.WriteLine("\nResult: ");
for(int i = 0; i < matrixResult.GetLength(0); i++)
{
    for(int j = 0; j < matrixResult.GetLength(1); j++)
    {
        Console.Write(matrixResult[i, j] + " ");
    }
    Console.WriteLine();
}
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] SpiralOfArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    int index = 0;
    int[] aim = {0, columns};

    while (temp <= rows * columns)
    {
        for (; j < aim[1]; j++)
        {
            array[i, j] = temp;
            temp++;
        }
        aim[0] = rows - index;
        i++;
        j--;

        for (; i < aim[0]; i++)
        {
            array[i, j] = temp;
            temp++;
        }
        aim[1] = index;
        j--;
        i--;
        index++;

        for (; j >= aim[1]; j--)
        {
            array[i, j] = temp;
            temp++;
        }
        aim[0] = index;
        i--;
        j++;

        for (; i >= aim[0]; i--)
        {
            array[i, j] = temp;
            temp++;
        }
        aim[1] = columns - index;
        j++;
        i++;
    }
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = SpiralOfArray(rows, columns);
Show2dArray(newArray);
*/