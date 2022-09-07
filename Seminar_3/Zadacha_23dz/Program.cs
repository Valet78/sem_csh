using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.Write("Введите целое число больше нуля: ");
        int num = Convert.ToInt16(Console.ReadLine ());
        
        if (num > 0) {
            for(int i=1; i <= num; i++){
                Console.Write(i*i*i);
            if (i < num) Console.Write(", ");
            }
        } else Console.WriteLine("Введено недопустимое значение!");

    }
}


/*

Задача 23: Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


*/