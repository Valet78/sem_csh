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
                number = Convert.ToUInt16(number_str);
                if (number > 0) {
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
               
    }

            

}
    