//  Задача № Является ли число 2 квадратом числа 1
/*
int num1 = -3;
int num2 = 9;
if (num2 == num1*num1)
{
    Console.WriteLine("-> ДА");
}
else
{
    Console.WriteLine("-> НЕТ");
}
*/
// Задача № "Вывод названия дня недели по вводу номера дня недели"
/*
int daynumber;
Console.WriteLine("Введите порядковый номер дня недели");
daynumber = Convert.ToInt32 (Console.ReadLine());

    if(daynumber==1)
        {
            Console.WriteLine("Понедельник");
        }
    if(daynumber==2)
        {
            Console.WriteLine("Вторник");
        }       
   if (daynumber==3)
        {
            Console.WriteLine("Среда");
        }
    if (daynumber==4)
        {
            Console.WriteLine("Четверг");
        }    
    if (daynumber==5)
        {
            Console.WriteLine("Ура, пятница!!!");           
        }    
    if (daynumber==6)
        {
            Console.WriteLine("Суббота");
        }    
    if(daynumber==7)
        {
            Console.WriteLine("Воскресенье");
        }  
else Console.WriteLine("Ни фига");
*/



//  Задача № 5 "Квадрат числа"
/*
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
PrintPower(number);

void PrintPower(int number)
{
    Console.WriteLine($"{number} * {number} = {number * number}");
}
*/

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Задача № 7 От - N до N

Console.WriteLine("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int i=-num;
while (i <= num)
    {
        Console.Write(" "+i);
        i++;
       
    }