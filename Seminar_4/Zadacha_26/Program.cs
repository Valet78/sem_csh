/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();

            Console.WriteLine("Введите целое число:");
            string ? number_str = Console.ReadLine();
            
            if (number_str != "") {
                int simvl = LegthString (number_str ?? "0");
                if (simvl != -1) Console.WriteLine($"В числе {number_str} цифр {simvl}");       
                else Console.WriteLine("Введено некорректное число.");    
            }
            else Console.WriteLine("Вы забыли ввести число. Попробуйте снова.");
                        
                        
            int LegthString (string num_str){
                int res = num_str.Length;                
                int num = 0;
                
                try {
                    num = Convert.ToInt32(num_str);
                    if (res == 1 && !(num >=0 && num <= 9)) res = -1;
                    if (res > 1 && num < 0) res -= 1;
                }
                catch (Exception){
                    res = -1;
                }            

                return res;
            }
               
    }

            

}

