// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
//округлёнными до одного знака.
// m = 3, n = 4.

void FillArrayDouble(double[,] numbers, double minValue = 0, double maxValue = 1)
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
    if (userRow >= 0 &&
        userColumn >= 0 &&
        userRow < rows &&
        userColumn < columns)
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

/*Задача 54. Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


void SortArray2DrowsDown(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int temp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }

            }
        }
    }
}
void Zadacha54()
{
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    SortArray2DrowsDown(numbers);
    Console.WriteLine();
    PrintArray(numbers);

}

/*Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая
 будет находить строку с наименьшей суммой элементов.*/

void Zadacha56()
{
    int rows = 6;
    int columns = 10;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 1, 9);
    PrintArray(numbers);
    int indexMin = 0;
    int minSum = 9 * columns; //Максимальное значение элемента * на кол-во элементов

    for (int i = 0; i < rows; i++)
    {

        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum = sum + numbers[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                indexMin = i;
            }
        }
    }
    Console.WriteLine($"Минимальная сумма в {indexMin + 1} строке = {minSum}");

}

void Zadacha58()
{
    int rows = 5;
    int columns = 6;
    int indexRow = 0;
    int indexColumns = 0;
    int biasRow = 0;
    int biasColumn = 1;
    int steps = columns;
    int turn = 0;



    int[,] numbers = new int[rows, columns];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[indexRow, indexColumns] = i + 1;
        steps--;
        if (steps == 0)
        {
            steps = columns * (turn % 2) + rows * ((turn + 1) % 2) - 1 - turn / 2;
            int temp = biasRow;     // сдвиг по колонке вниз
            biasRow = biasColumn;
            biasColumn = -temp;
            turn++;
        }
        indexRow = indexRow + biasRow;
        indexColumns = indexColumns + biasColumn;

    }
    PrintArray(numbers);
}











//Zadacha58();
//Zadacha56();
//Zadacha54();
//Zadacha52();
//Zadacha47();
//Zadacha50();