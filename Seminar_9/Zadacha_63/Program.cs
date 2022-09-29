/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        
        Console.WriteLine("Введите число N для получения всех натуральных чисел в промежутке от 1 до N");
        int numN = inputNumRow();
        if(numN > 2) NumRangeOut (numN);
        else Console.WriteLine($"В промежутке между 1 и {numN} нет натуральных чисел. Попробуйте снова и введите число больше 2.");
        Console.WriteLine("");



        void NumRangeOut (int num){
            string numStr = String.Empty;
            Console.Write($"N = {numN} -> \"");
            for(int i = 1; i <= numN; i++){
                numStr += Convert.ToString(i);
                if(i < numN) numStr += ", ";
            }
            Console.Write($"{numStr}\"");
        }        
        
       
        // Ввод числа
       int inputNumRow(){
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