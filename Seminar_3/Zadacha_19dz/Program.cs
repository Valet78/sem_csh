using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.Write("Введите целое число: ");
        string num_str = Console.ReadLine ();
        int flag = 0, start = 0, len = num_str.Length-1;
        int num = Convert.ToInt32(num_str);

        if ((num > 0 && len > 1) || (num < 0 && len > 2)){
            if (num < 0) start = 1;
            for (int i=start; i <= len/2; i++){
                
                if(num_str[i] != num_str[len-i+start]) {
                    flag=-1;
                    break;
                }

            }
            if(flag == -1) Console.WriteLine($"Число {num_str} не является палиндромом.");
            else if(flag == 0) Console.WriteLine($"Число {num_str} палиндром.");

        }
        else Console.WriteLine("Введено некоректное значение! Цифр в числе должно быть более одной.");        

    }
}


/*

Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да


*/
