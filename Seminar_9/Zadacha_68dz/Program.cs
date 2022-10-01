/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/


using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        
        Console.WriteLine("Для вычисления функции Аккермана введите два неотрицательных числа M и N");
        int numM = inputNum("M = ");
        int numN = inputNum("N = ");
        Console.WriteLine($"m = {numM}, n = {numN} -> A(m, n) = {FunctionA(numM, numN)}");

        // Вычисления функции Аккермана
        int FunctionA(int n, int m) {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return FunctionA(n - 1, 1);
                if (n > 0 && m > 0) return FunctionA(n - 1, FunctionA(n, m - 1));
                return FunctionA(n,m);
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
            if (inputInt < 0) tryRes = false;                                
            return tryRes;
        }
    }
}