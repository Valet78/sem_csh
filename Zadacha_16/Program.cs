// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите два целых числа");
Console.Write("первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 == num_2 * num_2 || num_2 == num_1 * num_1) Console.WriteLine("да");
    else Console.WriteLine("нет");
