// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

void Zadacha34()
{
    Console.WriteLine("Введите количество чисел для поиска четных");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    int otvet = 0;

    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            otvet++;
        }
    }
    Console.WriteLine("Количество четных чисел = " + otvet);

}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов с нечётными индексами.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void Zadacha36()
{
    Console.WriteLine("Введите количество чисел в массиве");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers, -50, 50);
    PrintArray(numbers);
    int SumElements = 0;
    for (int i = 1; i < size; i += 2)
    {
        SumElements = SumElements + numbers[i];
    }
    Console.WriteLine("Сумма элементов с нечетными индексами =  " + SumElements);

}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

void FillArray2(double[] nums, int minValue, int maxValue)
{
    int length = nums.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.NextDouble() + rand.Next(minValue, maxValue);
        nums[i] = Math.Round(nums[i], 2);
    }
}
void PrintArray2(double[] nums)
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


void Zadacha38()
{
    int size = 8;
    double[] massiveZ = new double[size];
    double minElement = 10;
    double maxElement = -10;
    double otvet = 0;
    FillArray2(massiveZ, -10, 10);
    PrintArray2(massiveZ);
    for (int i = 1; i < size; i++)
    {
        if (massiveZ[i] < minElement)
        {
            minElement = massiveZ[i];
        }
        else if (massiveZ[i] > maxElement)
        {
            maxElement = massiveZ[i];
        }
    }
    otvet = maxElement - minElement;
    Console.Write("Максимальное значение " + maxElement + " - минимальное значение " + minElement);
    Console.WriteLine(" = " + otvet);
}





Zadacha38();
//Zadacha36();
//Zadacha34();