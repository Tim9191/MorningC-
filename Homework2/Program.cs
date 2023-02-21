// Task 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondNumber(int num)
{
    int hundreds = num % 100;
    int result = (num % 100) / 10;

    return result;
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondNumber = ShowSecondNumber(num);
Console.WriteLine($"SecondNumber of {num} is {SecondNumber}");
*/



// Task 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool weekEnd(int dayNum)
{
    return (dayNum == 6 || dayNum == 7);
}
Console.Write("Input the day number: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if(weekEnd(dayNum))
Console.WriteLine("It is a weekend");
else
Console.WriteLine("It is a not weekend");
*/

// Task 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

/*
int ThirdDigit(int num)
{
    while(num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.WriteLine("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("No third digit");
}
else 
{
    Console.WriteLine(ThirdDigit(num));
}
*/



    