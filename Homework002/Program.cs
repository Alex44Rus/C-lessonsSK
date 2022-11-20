//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
void Zadacha10()
{
    Console.WriteLine("Введите 3-х значное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99 && number < 1000)
    {
        number = number / 10;
        int res = number % 10;
        Console.WriteLine($"Вторая цифра числа = " + res);
    }
    else Console.WriteLine("Ха ха, попробуйте еще раз!");

}

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
void Zadacha13()
{
    Random rand = new Random();
    int number = rand.Next(0, 100000);
    Console.WriteLine("Введено число  " + number);
    while (number > 1000)
    {
        number = number / 10;
    }
    int res = number % 10;

    Console.WriteLine("Третья цифра в цисле  " + res);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void Zadacha15()
{
Console.WriteLine("Введите номер дня недели ");
int daynum = Convert.ToInt32(Console.ReadLine());
if (daynum > 0 && daynum < 8)
{
    if (daynum > 1 && daynum < 6)
    {
        Console.WriteLine("Будний день ");    
    }
    else Console.WriteLine("Выходной день ");
}
else Console.WriteLine("Ввод не корреткный! ");
}





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

//Задача 1. Рассчитать значение y при заданном x по формуле

void DopZadacha1()
{
    Console.WriteLine("Введите значение х");
    double x = Convert.ToDouble(Console.ReadLine());
    double y = 0;
    if (x > 0)
    {
        y = Math.Pow(Math.Sin(x), 2);
        // Console.WriteLine("Ответ = " + y);
    }
    else
        y = (1 - 2 * Math.Sin(Math.Pow(x, 2)));
    Console.WriteLine("Ответ = " + y);
}

void DopZadacha2()
//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Введено число: " + number);

    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    if (sum % 3 == 0)
    {
        Console.WriteLine("Сумма всех цифр кратна 3-м, т.е. и все число делится на 3 без остатка!");
    }
    else Console.WriteLine($"Сумма всех цифр = {sum} не кратна 3-м! ");
}

//Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

// void DopZadacha3()
// {



// }





Zadacha15();
Zadacha13();
Zadacha10();
//Zadacha23();
//Zadacha21();
//Zadacha19();
//DopZadacha1();
//DopZadacha2();