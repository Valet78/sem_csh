using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.Write("Введите целое число, отличное от нуля: ");
        int num = Convert.ToInt16(Console.ReadLine ());
        int num_abs = Math.Abs(num);
        if (num != 0) {
            for(int i=1; i <= num_abs; i++){
                Console.Write(i*i);
            if (i < num_abs) Console.Write(", ");
            }
        } else Console.WriteLine("Введено недопустимое значение!");

    }
}


/*

Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4


*/
