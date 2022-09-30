/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2"

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        
        Console.WriteLine("Введите число N для получения всех чётных чисел в промежутке от N до 1");
        int numN = inputNum();
        if(numN > 2) NumRangeOut (numN);
        else Console.WriteLine($"В промежутке между 1 и {numN} нет натуральных чисел. Попробуйте снова и введите число больше 2.");
        Console.WriteLine("");



        void NumRangeOut (int num){
            string numStr = String.Empty;
            Console.Write($"N = {numN} -> \"");
            for(int i = numN; i >= 1; i--){
                if (i % 2 == 0) {
                    numStr += Convert.ToString(i);
                    if(i > 2) numStr += ", ";
                }
            }
            Console.Write($"{numStr}\"");
        }        
       
        // Ввод числа
       int inputNum(){
            int temp = 0;
            Console.Write("N = ");
            while (!TryInputText (Console.ReadLine() ?? String.Empty, ref temp)){
                Console.WriteLine("Введено некорректное число. Попробуйте снова.");
                Console.Write("N = ");
                temp = 0;
            }
            return temp;
       }

       // Проверка правильности ввода числа   
        bool TryInputText (string inputText, ref int inputInt){
            bool tryRes = true;            
            if(!Int32.TryParse(inputText, out inputInt)) tryRes = false; 
            if (inputInt < 1)tryRes = false;                                
            return tryRes;
        }
    }
}