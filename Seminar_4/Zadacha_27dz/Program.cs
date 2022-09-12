/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            
            Console.WriteLine("Введите целое число:");
            string ? num_str = Console.ReadLine();

            if (num_str != ""){               
                int len = num_str!.Length;
                int sum = 0, temp = 0;
                bool tryText = true;
                
                temp = TryInputText (num_str, ref tryText);
                if (tryText){                    
                    for(int i = 0; i < len; i++){
                        if(num_str[i] == '-') continue;
                        sum += Convert.ToInt32(num_str[i].ToString());                    ;
                    }
                Console.WriteLine($"Сумма цифр в числе {num_str} равна {sum}");                
                }
                else Console.WriteLine("Введено некорректное число. Попробуйте снова.");
            }
            else Console.WriteLine("Введено некорректное число. Попробуйте снова.");

                        // Проверка правильности ввода числа   
            int TryInputText (string inputText, ref bool tryText){
                int try_res=0;
                if(!int.TryParse(inputText, out try_res)) tryText = false;
                return try_res;
            }            
    }           

}
    