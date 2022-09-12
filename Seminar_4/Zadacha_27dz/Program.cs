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
                int len = num_str.Length;
                int sum = 0, temp = 0;
                for(int i = 0; i < len; i++){
                    if(num_str[i] == '-') continue;
                    temp = TryInputText (num_str[i].ToString());
                    if(temp != -1) sum += temp; 
                    else Console.WriteLine("Введено некорректное число. Попробуйте снова.");
                }
                Console.WriteLine($"Сумма цифр в числе {num_str} равна {sum}");                
                }
                else Console.WriteLine("Введено некорректное число. Попробуйте снова.");
            

                        // Проверка правильности ввода числа   
            int TryInputText (string InputText){
                int try_res=0;
                if(!int.TryParse(InputText, out try_res)) try_res = -1;
                return try_res;
            }            
    }           

}
    