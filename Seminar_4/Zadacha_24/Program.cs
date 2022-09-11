/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();

            int number = 0;

            Console.WriteLine("Для вычисления суммы чисел от 1 до А введите целое число больше единицы:");
            string ? number_str = Console.ReadLine();
            
            if (number_str != "") {
                //number = Convert.ToUInt16(number_str);
                number =  TryInputText(number_str);   
                if (number != -1) {
                        int summ = GetSumm(number);
                        Console.WriteLine($"Сумма чисел от 1 до А = {number} равна {summ}");

                    }
                    else Console.WriteLine("Введено некорректное число!");
           
            }
            else Console.WriteLine("Вы забыли ввести число. Попробуйте снова.");
                        
                        
            int GetSumm(int num){
               int res = 0;
               for (int ind = 1; ind <= num; ind++) {
                    res += ind;
                }
                
                return res;
            }
            // Проверка правильности ввода числа   
            int TryInputText (string ? InputText){
                int try_res=0;
                if(int.TryParse(InputText, out try_res)){
                    if(try_res < 1) try_res = -1;
                } 
                else try_res = -1;
                return try_res;
            }







    }

            

}
    
    
    




