//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число ");
    string number5x = Console.ReadLine();
    var array = number5x.Split();
    int arraylong = number5x.Length;
    if (arraylong != 5)
    {
        Console.WriteLine("Введите число состоящее из ПЯТИ символов");
    }
    else if (number5x[0] == number5x[4] && number5x[1] == number5x[3])
        Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


void Zadacha21()
{

    double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        var x = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return Math.Round(x, 2);
    }
    Console.WriteLine("Введи координату x Первой точки");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи координату y Первой точки");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи координату z Первой точки");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи координату x Второй точки");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи координату y Второй точки");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи координату z Второй точки");
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Расстояние между точками равно =   + {Distance3D(x1, y1, z1, x2, y2, z2)}");
}

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
//чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Zadacha23()
{
    Console.WriteLine("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.Write(" " + Math.Pow(i, 3));
    }
}


//Zadacha23();
//Zadacha21();
//Zadacha19();