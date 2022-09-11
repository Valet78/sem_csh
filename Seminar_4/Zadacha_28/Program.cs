/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();

            int number = 0;

            Console.WriteLine("Для вычисления произведения чисел от 1 до N введите целое число больше единицы:");
            string ? number_str = Console.ReadLine();
            
            if (number_str != "") {
                number = TryInputText(number_str ?? "0");
                if (number != -1) {
                        int summ = GetSumm(number);
                        Console.WriteLine($"Произведение чисел от 1 до N = {number} равно {summ}");

                    }
                    else Console.WriteLine("Введено некорректное число!");
           
            }
            else Console.WriteLine("Вы забыли ввести число. Попробуйте снова.");
                        
                        
            int GetSumm(int num){
               int res = 1;
               for (int ind = 1; ind <= num; ind++) {
                    res *= ind;
                }
                
                return res;
            }

                        // Проверка правильности ввода числа   
            int TryInputText (string InputText){
                int try_res=0;
                if(int.TryParse(InputText, out try_res)){
                    if(try_res < 1) try_res = -1;
                } 
                else try_res = -1;
                return try_res;
            }

               
    }

            

}
    