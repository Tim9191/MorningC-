// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimum possible value: ");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a maximum possible value: ");
double maxValue = Convert.ToDouble(Console.ReadLine());

double[,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreatRandom2dArray(int [,] array)
{
     for(int i = 0; i < array.GetLength(0); i++) 
     {
         for(int j = 0; j < array.GetLength(1); j++)
         {
             array[i,j] = new Random().Next(1, 10);
         }
     }
     return array;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++) 
     {
         for(int j = 0; j < array.GetLength(1); j++)
             Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
 }

 Console.Write("Enter a number of rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter a number of columns: ");
 int columns = Convert.ToInt32(Console.ReadLine());

 int [,] numbers = new int [rows, columns];
 CreatRandom2dArray(numbers);
 Show2dArray(numbers);


    
for(int j = 0; j < numbers.GetLength(1); j++)
 {
    double count = 0;
    for(int i = 0; i < numbers.GetLength(0); i++) 
    {
        count = (count + numbers[i, j]); 
    }     count = count / columns; 
    Console.Write(count + "; ");        
} 
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
using System;

namespace Homework7
{
    class Program
    {
        public static int GetValue(int i, int j)
        {
            int[,] array = 
            {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
            };
            
            if(i < 0 || j < 0 || i >= array.GetLength(0) || j >= array.GetLength(1))
                throw new Exception("Error. Index was outside from bones of array.");

            return array[i, j];
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(GetValue(0, 0));
            System.Console.WriteLine(GetValue(1, 1));
            System.Console.WriteLine(GetValue(32, 77));
            int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
            int[,] newArray = new int[10, 5];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");

            for(int i = 0; i < newArray.GetLength(0); i++)
            {
                for(int j = 0; j < newArray.GetLength(1); j++)
                {
                    Console.Write(newArray[i, j] + " ");
                }   
                Console.WriteLine();         
            
        }
    }
}
*/





