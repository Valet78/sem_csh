/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/


using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        
        Console.WriteLine("Введите числа M и N для получения всех натуральных чисел в промежутке от M до N");
        int numM = inputNum("M = ");
        int numN = inputNum("N = ");

        if((numN - numM) > 1) NumRangeOutSum (numM, numN);
        else Console.WriteLine($"В промежутке между {numM} и {numN} нет натуральных чисел. Попробуйте снова.");
        Console.WriteLine("");



        void NumRangeOutSum (int numStart, int numStop){
            int numSum = 0;
            for(int i = numStart; i <= numStop; i++) numSum += i; 
            Console.Write($"M = {numStart}; N = {numStop} -> {numSum}");
        }         
       
        // Ввод числа
       int inputNum(string text){
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