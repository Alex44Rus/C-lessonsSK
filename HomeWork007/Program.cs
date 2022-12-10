// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
//округлёнными до одного знака.
// m = 3, n = 4.

void FillArrayDouble(double[,] numbers, double minValue = 0, double maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(10 * rand.NextDouble(), 1);
        }
    }
}
void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            //Console.Write($"A[{i}, {j}] = {numbers[i,j]}      ");// Вывод с индексами
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void Zadacha47()
{
    int rows = 3; //m
    int columns = 4; //n
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);

}

//Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    int rows = 5;
    int columns = 5;
    int[,] numbers5x5 = new int[rows, columns];
    FillArray(numbers5x5, 0, 9);
    PrintArray(numbers5x5);
    Console.WriteLine("Введите № строки элемента ");
    int userRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите № столбца элемента ");
    int userColumn = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (userRow < rows && userColumn < columns)
    {
        Console.WriteLine($" Выбранный элемент = {numbers5x5[userRow - 1, userColumn - 1]}");
    }
    else Console.WriteLine("Попробуйте еще раз))");

}

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 5 3
8 4 6 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
*/

void Zadacha52()
{
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 1, 9);
    PrintArray(numbers);
    double average = 0;
    
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers[i, j];
        }
        average = sum / rows;
        average = Math.Round(average, 1);
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца =  {average}");
    }
}















Zadacha52();
//Zadacha47();
//Zadacha50();