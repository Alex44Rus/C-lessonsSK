//Задача 25: Используя определение степени числа, напишите цикл, который принимает на
// вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Zadacha25()
{
    Console.WriteLine("Введите первое натуральное число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе натуральное число ");
    int b = Convert.ToInt32(Console.ReadLine());
    int res = 1;
    if (a <= 0 | b <= 0)
    {
        Console.WriteLine("Ошибка ввода, нужны числа больше 0");

    }
    else
        for (int i = 1; i <= b; i++)
        {
            res = res * a;
        }

    Console.WriteLine($"Введены числа {a} и {b} ответ  {res}");
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Zadacha27()
{
    //Console.WriteLine("Введите число ");
    //int number = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    int number = rand.Next();
    Console.WriteLine("Введено случайное число   " + number);
    int otvet = 0;
    while(number > 0)
    {
        otvet = otvet + number % 10;
        number = number / 10;
    }    
    Console.WriteLine("Сумма цифр числа =   " + otvet);

}


//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых
// чисел и выводит отсортированный по модулю массив.

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-100, 100); //ограничил кол-во слусчайных чисел от -100 до 100
    }
}
void SortArray(int[] nums)
{
    int temp;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i +1; j < nums.Length; j++)
        {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
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

void Zadacha29()
{
    int size = 8;
    int[] nums = new int[size];
    FillArray(nums);
    SortArray(nums);
    PrintArray(nums);
    Console.WriteLine();

}









//Zadacha29();
Zadacha27();
//Zadacha25();