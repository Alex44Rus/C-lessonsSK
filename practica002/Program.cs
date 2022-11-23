
void Zadacha17()
{
    // 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
    //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится
    // эта точка.
    Random rand = new Random();
    int x = rand.Next(-10, 11);
    int y = rand.Next(-10, 11);
    Console.WriteLine($"А  {x}, {y}");
    if (x < 0 && y < 0)
    {
        Console.WriteLine("3-ая четверть");
    }

    else if (x > 0 && y > 0)
    {
        Console.WriteLine("1-ая четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2-ая четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4-ая четверть");
    }

}




void Zadacha18()
{
    Console.WriteLine("Введите номер четверти ");
    int nomer = Convert.ToInt32(Console.ReadLine());
    if (nomer == 1)
    {
        Console.WriteLine("X и Y положительные");
    }
    else if (nomer == 2)
    {
        Console.WriteLine("X отрицательные, Y положительные");
    }
    else if (nomer == 3)
    {
        Console.WriteLine("X и Y отрицательные");
    }
    else if (nomer == 4)
    {
        Console.WriteLine("X положительные, Y отрицательные");
    }
    else Console.WriteLine("Ха-ха введите корректные данные");
}



// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.
//int x = 5;
//Math.Pow(x ,2);
//Math.Sqrt(x);
// Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1)), 2);

double Gipotenuza(int x1, int y1, int x2, int y2)
{

    var x = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Round(x, 3);    // округление
}
void Zadacha21()
{
    Random rand = new Random();
    int x1 = rand.Next(-10, 11);
    int y1 = rand.Next(-10, 11);
    Console.WriteLine($"х1 = {x1} y1 = {y1}");
    int x2 = rand.Next(-10, 11);
    int y2 = rand.Next(-10, 11);
    Console.WriteLine($"х2 = {x2} y2 = {y2}");

    Console.WriteLine($"Растояние между точками = {Gipotenuza(x1, y1, x2, y2)}");
}




//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Zadacha22()
{
    Console.WriteLine("Введите число   ");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    while (count <= n)
    {
        Console.WriteLine($"{count} * {count}  " + count * count);
        count++;
    }

}

void Zadacha24() //Сумма цифр от 1 до введенного числа
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);

    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {
        sum = sum + counter;
        Console.Write($"{counter}" + "{number}");
        Console.WriteLine(sum);
        counter++;
    }
}

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр
// в числе.

void Zadacha26()
{
    Random rand = new Random();
    int number = rand.Next(1, 9999999);
    Console.WriteLine("Введено число: " + number);
    int counter = 0;

    while (number > 0)
    {
        number = number / 10;
        counter++;
    }
    Console.WriteLine("Ответ  " + counter);

}

void Zadacha28()
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);

    int counter = 1;
    int sum = 1;
    while (counter <= number)
    {

        Console.Write($"{counter} * {sum} = ");
        sum = sum * counter;
        Console.WriteLine(sum);
        counter++;
    }
}


void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(0, 2);
    }
}
void PrintArray(int[] nums)
{   
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    
}    
//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
void Zadacha30()
{
    int size = 8;
    int[] numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("  ");
    
}






Zadacha30();
//Zadacha28();
//Zadacha26();
//Zadacha24();
//Zadacha18();
//Zadacha22();
//Zadacha17();
// Zadacha21();