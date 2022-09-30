/*
Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        
        Console.WriteLine("Введите числа M и N для получения всех натуральных чисел в промежутке от M до N");
        int numM = inputNumRow("M = ");
        int numN = inputNumRow("N = ");


        if((numN - numM) > 1) NumRangeOut (numM, numN);
        else Console.WriteLine($"В промежутке между {numM} и {numN} нет натуральных чисел. Попробуйте снова.");
        Console.WriteLine("");



        void NumRangeOut (int numStart, int numStop){
            string numStr = String.Empty;
            Console.Write($"M = {numStart}; N = {numStop} -> \"");
            for(int i = numStart; i <= numStop; i++){
                numStr += Convert.ToString(i);
                if(i < numStop) numStr += ", ";
            }
            Console.Write($"{numStr}\"");
        }        
        
       
        // Ввод числа
       int inputNumRow(string text){
            int temp = 0;
            Console.Write(text);
            while (!TryInputText (Console.ReadLine() ?? String.Empty, ref temp)){
                Console.WriteLine("Введено некорректное число. Попробуйте снова.");
                Console.Write(text);
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