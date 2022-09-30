/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/
using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        
        Console.WriteLine("Введите числа A и B для получения значения степени B по основанию A");
        int numA = inputNum("A = ");        
        int numB = inputNum("B = ");
        
        if (numB != 0){                        
            double degree = Convert.ToDouble(DegreeOfNumber(numA, Math.Abs(numB)));
            if (numB < 0) degree = Math.Round(1 / degree, 2);
            Console.WriteLine($"A = {numA}; B = {numB} -> {degree}");
        }   else Console.WriteLine($"A = {numA} в степени B = 0 всегда равно 1");
        
        Console.WriteLine("");


        int DegreeOfNumber (int num, int deg){             
            if (deg > 1)num *= DegreeOfNumber (num, -- deg); 
            return num;
        }
       
        // Ввод числа
       int inputNum(string text){
            int temp = 0;
            bool tryNum = false;
            string ? zapros = String.Empty;
            
            while (!tryNum){
                Console.Write(text);
                zapros = Console.ReadLine();
                if (zapros != String.Empty) {
                    tryNum = TryInputText (zapros ?? String.Empty, ref temp);
                    tryNum = true;                   
                } else {
                    tryNum = false;
                    Console.WriteLine("Введено некорректное число. Попробуйте снова.");                    
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