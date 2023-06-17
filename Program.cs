//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// невозвратный метод
/*
void NameFunk() // Имя метода (в скоюках аргументы)
{

}
NameFunk(); // вызов метода имя метода + аргументы
*/

// перед именем метода пишется тип возвращаемых данных
// int, bool, double, string FunktName (int arg1, bool arg2)


// Задача. Найти остаток от деления введенного числа на 9

/*
int FunktName (int arg1, int arg2)
{
     //arg1 = number
     //arg2 = 9

     int del = arg1 % arg2;
return del;
}

Console.WriteLine("Input ");
int number = Convert.ToInt32(Console.ReadLine());

int resul = FunktName(number, 9);
Console.WriteLine("1 " + resul);
int result = FunktName(1000, 78);
Console.WriteLine("2 " + result);
*/
/*
void FunktName1 ()
{
    Console.WriteLine("Input ");
    int number = Convert.ToInt32(Console.ReadLine());

    int del = number % 9;
    Console.WriteLine("1 " + del);
}
FunktName1 ();
*/

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/*
int Koord (int x, int y)
{
    int numberQt;
    if (x > 0 && y > 0) numberQt = 1;
    else if (x > 0 && y < 0) numberQt = 4;
    else if (x < 0 && y > 0) numberQt = 2;
    else numberQt = 3;
    return numberQt;
}

Console.WriteLine("Enter X coord: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coord: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
int numbQtr;

if (xCoord == 0 || yCoord == 0)
{
    Console.WriteLine("Error");
}
else
{
    numbQtr = Koord (xCoord, yCoord);
    Console.WriteLine($"Number of quater is {numbQtr}");
}
*/

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/*
int Diapason (int quadro)
{
if (quadro == 1)
return 1;
else if (quadro == 2)
return 2;
else if (quadro == 3)
return 3;
else
return 4;
}
System.Console.WriteLine("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (a <= 0 || a > 4) System.Console.WriteLine("Айяйяй");
else {
result = Diapason(a);

if (result == 1)
{
System.Console.WriteLine("Ваш диапазон x > 0 и y > 0");
}
else if (result == 2)
{
System.Console.WriteLine("Ваш диапазон x < 0 и y > 0");
}
else if (result == 3)
{
System.Console.WriteLine("Ваш диапазон x < 0 и y < 0");
}
else
{
System.Console.WriteLine("Ваш диапазон x > 0 и y < 0");
}
}
*/

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
// Второй вариант с методом

/*
void PossibleValue (int quadro)
{
    if (quadro == 1)
        Console.WriteLine ("1st quater x > 0, y > 0");
    else if (quadro == 2)
        Console.WriteLine ("2nd quater x < 0, y > 0");
    else if (quadro == 3)
        Console.WriteLine ("3rd quater x < 0, y < 0");
    else 
        Console.WriteLine ("4st quater x > 0, y < 0");
}

Console.WriteLine("Input number of quater: ")     ;
int numQater = Convert.ToInt32(Console.ReadLine());

if(numQater >= 1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine("its not number of quater!");
*/

//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A(x1,y1); B(x2,y2)

/*
double LongLineAB(int xA, int xB, int yA, int yB)
{
    double LongLine = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
    return (LongLine);
}

Console.WriteLine("Input X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB);
Console.WriteLine($"Distance between A({xCoordA},{yCoordA}) and B({xCoordB},{yCoordB}) is {dist:f3}");
*/

//Напишите программу, которая принимает на вход число (N) и 
//выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.

/*
void SqurePrinter(int numberN)
{
        int current = 1;
        while (current <= numberN)
        {
                double res = Math.Pow(current,2);
                Console.Write($"{res:f0}, ");
                current++;
        }
        Console.WriteLine("\b\b.");
}
void SqurePrinterNeg(int numberN)
{
        int current = 1;
        while (current >= numberN)
        {
                double res = Math.Pow(current,2);
                Console.Write($"{res:f0}, ");
                current--;
        }
        Console.WriteLine("\b\b.");
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
        SqurePrinter(user_number);
else
        SqurePrinterNeg(user_number);
*/