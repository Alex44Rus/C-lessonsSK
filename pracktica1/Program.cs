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
