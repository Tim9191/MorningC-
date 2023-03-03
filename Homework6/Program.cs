// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositiveNum(int m)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
     {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) temp++;
     }
    return temp;
}

Console.Write("Enter the required numbers: ");
int m = Convert.ToInt32(Console.ReadLine());

while(m < 0)
{
    Console.Write($"{m} is not a positive number");
    m = Convert.ToInt32(Console.ReadLine());
}

int temp = PositiveNum(m);
Console.WriteLine($"There are {temp} positive numbers");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void CrossingOfStraightLine(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
        if(b1 == b2)
            Console.WriteLine("The lines match");
        else
            Console.WriteLine("The lines are parallel");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Point of intersection of lines is [{x}; {y}]");
    }


}

Console.Write("Enter the value of k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

CrossingOfStraightLine(k1, b1, k2, b2);
*/


















