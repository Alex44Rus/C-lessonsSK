//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет
// все натуральные числа кратные 3-ём в промежутке от M до N.

void RecursionFInd3x(int number, int counter)
{
    if (counter > number) return;
    if (counter % 3 == 0)
        Console.Write($"{counter}   ");
    counter++;
    RecursionFInd3x(number, counter);
}

void Zadacha64()
{
    Console.WriteLine("Введите первое число");
    int digitFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int digitSecond = Convert.ToInt32(Console.ReadLine());

    RecursionFInd3x(digitSecond, digitFirst);
}

//Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который 
//найдёт сумму натуральных элементов в промежутке от M до N.

void RecursionSummElements(int number, int counter, int sum = 0)
{
    if (counter > number)
    {
        Console.WriteLine($"Ответ {sum} ");
        return;
    }

    sum = sum + counter;
    counter++;
    RecursionSummElements(number, counter, sum);
}



void Zadacha66()
{
    Console.WriteLine("Введите первое число");
    int digitFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int digitSecond = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    RecursionSummElements(digitSecond, digitFirst, sum);

}
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int RecursionAkkermanFunction(int m, int n)
{
    if (m == 0 && n != 0)   
    return n + 1;
    else
    if (n == 0 && m != 0)
        return RecursionAkkermanFunction(m - 1, 1);
    else    
        return RecursionAkkermanFunction((m - 1), RecursionAkkermanFunction(m, n - 1));
    RecursionAkkermanFunction(m, n);
}

void Zadacha68()
{
    int m = 3;
    int n = 2;
    RecursionAkkermanFunction(m, n);
    Console.WriteLine($"Функция Аккремана для чисел {m} , {n} = {RecursionAkkermanFunction(m, n)}");
}

//Zadacha66();
//Zadacha64();
Zadacha68();