using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.Write("Введите целое число больше нуля: ");
        int num = Convert.ToInt16(Console.ReadLine ());
        
        if (num != 0) {
            for(int i=1; i <= num; i++){
                Console.Write(i*i);
            if (i < num) Console.Write(", ");
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
