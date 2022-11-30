


void Zadacha31()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, 10, 19);
    PrintArray(numbers);
    FindSumPosElements(numbers);
    FindSumNegElements(numbers);
}


void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    int length = nums.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + "   ");
    }
    Console.WriteLine();
    Console.WriteLine();

}
void FindSumPosElements(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] > 0)
        {
            sum += nums[i];
        }
    }
    Console.WriteLine("Сумма положительных элементов " + sum);
}
void FindSumNegElements(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] < 0)
        {
            sum += nums[i];
        }
    }
    Console.WriteLine("Сумма отрицательных элементов " + sum);
}





void Zadacha32()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
        numbers[i] = numbers[i] * -1;
    }
    PrintArray(numbers);

}

void Zadacha33()
{
    int size = 5;
    int[] number = new int[size];
    FillArray(number, 0, 10);
    PrintArray(number);
    int zadnum = 5;
    bool flag = false;
    for (int i = 0; i < size && !flag; i++)
    {
        if (number[i] == zadnum)
        {
            flag = true;
        }
    }
    if (flag) Console.WriteLine($"{zadnum}  --> ДА");
    else Console.WriteLine($"{zadnum} --> НЕТ  ");

}

void Zadacha39()
{
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];

    FillArray(numbers, 0, 9);
    PrintArray(numbers);
    Console.WriteLine("\n");
    int[] result = new int[size];
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)
    {
        result[maxIndex - i] = numbers[i];
    }
    PrintArray(result);

    // 2-й способ

    for (int i = 0; i < size / 2; i++)
    {
        int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);//3-й способ КОРТЕЖи
    }


    PrintArray(numbers);

}

void Zadacha40() //Задача 40: Напишите программу, которая принимает на вход три числа и 
//проверяет, может ли существовать треугольник со сторонами такой длины.

{
    int a = 3;
    int b = 4;
    int c = 5;
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        Console.WriteLine($" {a} {b} {c} Да может");
    }
    else
        Console.WriteLine("Не может");
}

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
void Zadacha42()
{
    int desnum = 45;
    int result = 0;
    int bias = 1;


    while (desnum > 0)
    {
        result = result * 10 + desnum % 2 * bias;
        bias *= 10;
        desnum /= 2;
    }
    Console.WriteLine(result);
}
// Задача 35: Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов
// массива,значения которых лежат в отрезке [10,99].

void Zadacha35()
{
    int size = 10;
    int res = 0;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 200);
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 10 && numbers[i] < 100)
        {
            res++;
        }
    }
    if (res == 0) 
    {
        Console.WriteLine("Чисел от 10 до 99 нет");
    }
    else
    Console.WriteLine("Количесто чисел от 10 до 99 = " + res);
}
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
void Zadacha37()
{   
    int size = 9;
    int size2 = size / 2;
    int[] numbers = new int[size];
    int maxIndex = numbers.Length - 1;
    int[] newnumbers = new int[size2 + size % 2];
    int res = 0;
   
    FillArray(numbers, 0, 10);
    PrintArray(numbers);

    for (int i = 0; i < size2; i++)
    {
        res = (numbers[i] * numbers[maxIndex-i]);
        newnumbers[i] = res;
    }
    if (size % 2 == 1)
    {
        newnumbers[size2] = numbers[size2];
    }
    PrintArray(newnumbers);
}










//Zadacha35();
//Zadacha42();
//Zadacha40();
//Zadacha33();
//Zadacha32();
//Zadacha31();
//Zadacha39();
//Zadacha37();