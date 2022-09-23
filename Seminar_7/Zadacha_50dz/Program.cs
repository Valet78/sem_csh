/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1, 7] -> такого числа в массиве нет
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 3, massColumn = 4;
        int inputRow = 0, inputColumn = 0;
        int [,] massivRnd = new int [massRow, massColumn];
        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("В указанном ниже массиве укажите позицию искомого числа");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");        
        InputDataValid (ref inputRow, "ряд = ");
        



        void MassivFillRnd(int row, int column){
            Random rndValue = new Random();   
            int minValue = -100, maxValue = 101;         
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                massivRnd[i, j] = rndValue.Next(minValue, maxValue);
                }
            }
        }

        void MassivOutConsole(int row, int column){
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                Console.Write(massivRnd[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        // Проверка правильности ввода числа   
        int InputTextValid (string inputText, ref bool chknum){
            int tryRes = 0;
            chknum = true;
            if(!int.TryParse(inputText, out tryRes)) chknum = false;                                  
            return tryRes;
        }
        
        // Ввод данных в массив строк
        void InputDataValid (ref int inputData, string textQuery){
            bool res = false;
            string temp = String.Empty;

            Console.Write(textQuery);
            while (InputTextValid(Console))

            for (int i = 0; i < 4; i++){
               Console.Write(massLit[i]);
                
               temp = Console.ReadLine() ?? "0";
                if(temp == "") {
                    Console.WriteLine("Забыли ввести число. Попробуйте снова");
                    i--;
                } else if(!TryInputText(temp, i)){
                    Console.WriteLine("Введено некорректное число. Попробуйте снова");
                    i--;
                } else res = true;
            } 
            return res;
        }

       // Проверка правильности ввода числа   
        bool TryInputText (string inputText, int index){
            bool tryRes = true;            
            if(!double.TryParse(inputText, out massZnach[index])) tryRes = false;                                  
            return tryRes;
        }

        
    }
}