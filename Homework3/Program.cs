// Task 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
/*
bool CheckPalendrome(int num)
{
    if(num > 9999 && num < 100000)
        return true;

    else
    {
        return false;
        Console.WriteLine("It is not a five-digit number");
    }
}
bool Palendrome(int num)

{   
    int digitOne = num / 10000;
    int digitTwo = num / 1000 % 10;
    int digitFour = num / 10 % 10;
    int digitFive = num % 10;


    if(digitOne == digitFive && digitTwo == digitFour)
        {
            return true;
        }
    else 
        return false;
}
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (CheckPalendrome(num))
{
	if (Palendrome(num)) Console.WriteLine($"{num} is a palendrome");
	else Console.WriteLine($"Your number {num} is not a palendrome");
}
*/

// Task 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
/*
void cubeTable(int Num)
{
    int currentNum = 1;
    while(currentNum <= Num) 
    {
        Console.WriteLine(currentNum + " " + (currentNum * currentNum * currentNum));
        currentNum++;
    }
}
Console.Write("Input an integer number: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num > 0)
    cubeTable(Num);
else
    Console.Write("Input a number bigger than 0: ");
*/

// Task 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
/*
double getDistance3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}
Console.Write("Input the coordinate X of the first point: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y of the first point: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Z of the first point: ");
double za = Convert.ToDouble(Console.ReadLine());


Console.Write("Input the coordinate X of the second point: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y of the second point: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Z of the second point: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between the points in the 3D space: " + getDistance3D(xa, ya, za, xb, yb, zb), 2);
*/











