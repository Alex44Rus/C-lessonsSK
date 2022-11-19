/*
// Задача 2
Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"Большее число  " + num2);
    Console.WriteLine($"Меньшее число  " + num1);
}
else if (num2 < num1)
    {
        Console.WriteLine($"Большее число  " + num1);
        Console.WriteLine($"Меньшее число  " + num2);
    }
    else Console.WriteLine("Они равны");

*/
//  Задача № 4

/*
// Задача №6
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int priz = number%2;
if (priz ==0)
    {
        Console.WriteLine("Введенное число четное ");
    }
else 
Console.WriteLine("Введенное число нечетное ");        
*/

//Задача №8   на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int number8 = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (number8 > 1)

    while (i <=number8)
    {
        if (i % 2 == 0)
        {
         Console.Write("  " + i);
        }
         i++;
    }
else Console.WriteLine("От 1 до вашего числа четных нет");    