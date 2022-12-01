//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вы вводили числа");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + "   ");
    }
    Console.WriteLine();
}


void Zadacha41()
{
    int counter = 0;
    Console.WriteLine("Сколько чисел будем вводить? ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] userNumbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число " + (i + 1));
        userNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    PrintArray(userNumbers);

    for (int i = 0; i < size; i++)
    {
        if (userNumbers[i] > 0)
        {
            counter++;
        }
    }

    Console.WriteLine($"Введено положительных чисел ..... >> {counter} ");
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Zadacha43()
{
    double x = 1;
    double y = 1;
    Console.Write("Введите k1  ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1  ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите k2  ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2  ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

        Console.WriteLine($"Координаты точки пересечения = {x}, {y}");
    }
    else
        Console.WriteLine("Прямые параллельны ");
}


//Zadacha41();
Zadacha43();