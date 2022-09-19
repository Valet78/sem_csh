/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    45 -> 101101
    3 -> 11
    2 -> 10

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        Console.Write("Введите целое положительное число для преобразования его в двоичное: ");
        string ? numStr = Console.ReadLine();
        if (numStr != "") {
            bool checkNum = true;
            int numInt = TryInputText (numStr ?? "0", ref checkNum);
            if(checkNum){
                string numInBin = "";
                if (numInt == 0) numInBin = "0";
                numInBin = NumConversion(numInt, ref numInBin);
                Console.WriteLine($"Число {numInt} в двоичной форме {numInBin}");

            } else Console.WriteLine("Введено некорректное число!");
        } else Console.WriteLine("Введено некорректное число!");


        // Проверка правильности ввода числа   
        int TryInputText (string InputText, ref bool chknum){
            int tryRes=0;
            if(!int.TryParse(InputText, out tryRes)) chknum = false;
            if(tryRes < 0) chknum = false;
            return tryRes;
        }

        // Перевод в двоичную систему
        string NumConversion(int number, ref string textBin){
           
           if(number != 0){      
                textBin = Convert.ToString(number % 2) + textBin;
                number /= 2;
                textBin = NumConversion((number), ref textBin);
            }    
            return textBin;
        }
    }
}