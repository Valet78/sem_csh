// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
//    44 5 78 -> 78
//    22 3 9 -> 22


        int chisl_a=0, chisl_b=0, chisl_c=0, max=0;
        Console.WriteLine("Введите три целых числа для сравнения:");
        Console.Write("a = ");
        chisl_a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        chisl_b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c = ");
        chisl_c = Convert.ToInt32(Console.ReadLine());

        if (chisl_a > chisl_b && chisl_a > chisl_c) max=chisl_a;
        if (chisl_b > chisl_a && chisl_b > chisl_c) max=chisl_b;
        if (chisl_c > chisl_a && chisl_c > chisl_b) max=chisl_c;

        Console.WriteLine($"Из трёх чисел a = {chisl_a}, b = {chisl_b} и c = {chisl_c} максимальное значение {max}");

