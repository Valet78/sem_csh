// Написать программу, котора на вход получает два числа и проверяет, является ли перво число квадратом второго
//  a=25, b=5 -> да
//  a=2, b=10 -> нет
//  a=9, b=-3 -> да
//  a=-3, b=9 -> нет


int a=0, b=0, sqr=0;
Console.WriteLine("Введите два целых числа:");
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
sqr = b * b;
if (a == sqr) Console.WriteLine("да");
    else Console.WriteLine("нет");
    