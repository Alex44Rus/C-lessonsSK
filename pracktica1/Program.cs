int num1;
int num2;
Console.WriteLine("Введите первое число");
num1 = Convert.ToInt32(Console.ReadLine (num1));
Console.WriteLine("Введите второе число");
num2 = Convert.ToInt32(Console.ReadLine(num2));
if (num2 = num1*num1)
{
    Console.WriteLine("-> ДА");
}
else
{
    Console.WriteLine("-> НЕТ");
}

int daynumber;
Console.WriteLine("Введите порядковый номер дня недели");
daynumber = Convert.ToInt32 (Console.ReadLine());
if (daynumber < 8)
{
    if(daynumber=1)
        {
            Console.WriteLine("Понедельник"))
        }
    if(daynumber=2)
        {
            Console.WriteLine("Вторник")
        }       
}
else
{
    Console.WriteLine("Дня недели с таким номером не существует, подумай еще!!!!!!!");
}