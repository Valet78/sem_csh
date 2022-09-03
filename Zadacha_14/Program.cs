// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//  14 -> нет
//  46 -> нет
//  161 -> да

Console.Write("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());

int ost7 = num % 7;
int ost23 = num % 23;
Console.WriteLine(ost7 + " " + ost23);
if (ost7 == 0 && ost23 == 0) Console.WriteLine($"Число {num} одновременно кратно числам 7 и 23");
    else Console.WriteLine($"Число {num} не кратно числам 7 и 23");
