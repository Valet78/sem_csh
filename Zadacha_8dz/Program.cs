// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num = 0;
Console.Write("Введите положительное целое число от 1: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 0) 
{
    for (int i=1; i <= num; i++)
    {  
        if (i % 2 == 0) 
        {
            Console.Write(i);
            if (i < num-1) Console.Write(", ");
        }
    }

}
else Console.WriteLine("Введено недопустимое значение!");