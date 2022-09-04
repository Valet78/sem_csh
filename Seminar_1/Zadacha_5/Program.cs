// Напишите программу, которая получает трёхзначное число и выводт третью цифру в числе
// 345 -> 5

int num = 0;
Console.Write("Введите трёхзначное целое число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) Console.WriteLine($"Последняя цифра числа {num}: {num % 10}.");
    else Console.WriteLine("Введенное число не соответствует условию задачи!");
    