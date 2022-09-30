/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.

453 -> 12
45 -> 9

*/


using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        
        Console.WriteLine("Введите числа натуральное число (больше \"0\") для получения суммы его чисел");
        int num = inputNumRow("Ваше число: ");        
        Console.WriteLine(Convert.ToString(SumChisl(num, 0)));
        

        int SumChisl(int numIn, int numDec){
            if (numIn != 0){                
                numDec += SumChisl(numIn / 10, numIn % 10);               
            }  
            return numDec;
        }
       
        // Ввод числа
       int inputNumRow(string text){
            int temp = 0;
            bool tryNum = false;
            Console.Write(text);
            while (!tryNum){
                tryNum = TryInputText (Console.ReadLine() ?? String.Empty, ref temp);
                if(temp < 1){
                    Console.WriteLine("Введено некорректное число. Попробуйте снова.");
                    Console.Write(text);
                    temp = 0;
                }
                
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