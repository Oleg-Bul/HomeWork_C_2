
int SecondDigit(int secondx)
{
    Console.WriteLine("Введите трехзначное число");
    int a = int.Parse(Console.ReadLine());
    secondx = (a / 10 % 10);
    {
        Console.WriteLine("Вторая цифра вашего числа " +  secondx);
    }    
    return secondx;
}
int secondx = SecondDigit(0);
//................................................................................


int thirdDigit(int third)
{
    
    Console.WriteLine("Введите трехзначное число");
    int a = int.Parse(Console.ReadLine());
    if(a>99)
    {
        third = (a % 100 % 10);
        {
        Console.WriteLine("Третья цифра вашего числа " +  third);
        }  
    } 
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }     
    return third;
}
int second = thirdDigit(0);
//...................................................................................

int weekendDay(int weekend)
{
    
    Console.WriteLine("Введите цифру (от 1 до 7) обозначающую день недели");
    int x = int.Parse(Console.ReadLine());
    if(x>5)
    {
        
        Console.WriteLine(x + " ваш день недели выходной");
         
    } 
    else
    {
        Console.WriteLine(x + " ваш день недели не выходной");
    }     
    return x;
}
int weekend = weekendDay(0);