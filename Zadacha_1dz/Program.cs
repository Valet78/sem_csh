// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int chisl_a=0, chisl_b=0, max=0;
        Console.WriteLine("Введите два целых числа для сравнения:");
        Console.Write("a = ");
        chisl_a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        chisl_b = Convert.ToInt32(Console.ReadLine());
        
        if (chisl_a > chisl_b) max=chisl_a;
        else max=chisl_b;
        
        Console.WriteLine($"Из двух чисел a = {chisl_a} и b = {chisl_b}  максимальное значение {max}");
