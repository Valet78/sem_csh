// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
//     кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//  34, 5 -> не кратно, остаток 4
//  16, 4 -> кратно


Console.WriteLine("Введите два целых числа:");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
int ost = a % b;

if (ost != 0) Console.WriteLine($"Число b = {b} не кратно числу a = {a}, остаток от деления равен {ost}");
    else Console.WriteLine($"Число b = {b} кратно числу a = {a}");
