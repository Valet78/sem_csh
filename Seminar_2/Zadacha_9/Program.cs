// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
//    наибольшую цифру числа.
//    78 -> 8
//    12-> 2
//    85 -> 8


int num = new Random().Next(10, 99);
int des = num / 10;
int edin = num % 10;
int max = 0;
if (des > edin) max = des;
    else max = edin;

Console.WriteLine($"В числе {num} наибольщая цифра {max}");