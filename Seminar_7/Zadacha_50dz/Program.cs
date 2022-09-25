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
        
        int [,] massivRnd = new int [massRow, massColumn];
        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("В указанном ниже массиве укажите позицию искомого числа");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");        
        int inputRow = InputDataValid ("ряд = ");
        int inputColumn = InputDataValid ("столбец = ");
        Console.Write($"[{inputRow}, {inputColumn}] - > ");
        if(inputRow < massRow && inputColumn < massColumn){
            Console.WriteLine($"{massivRnd[inputRow, inputColumn]}");
        } else Console.WriteLine("такого числа в массиве нет");
         

       
        // Ввод и проверка  
        int InputDataValid (string textQuery){
            //string temp = String.Empty;
            bool resTry = false;
            int inputDataInt = 0;
            while (!resTry) {
                Console.Write(textQuery);
                inputDataInt = InputTextValid (Console.ReadLine() ?? "0");
                if (inputDataInt >= 0){
                    resTry = true;
                } else Console.WriteLine("Введено некорректное число. Попробуйте снова.");

            }
            return inputDataInt;
        }
            
        // Проверка правильности ввода числа   
        int InputTextValid (string inputText){
            int tryRes = 0;
            if(!int.TryParse(inputText, out tryRes)) tryRes = - 1;                        
            return tryRes;
        } 

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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("R/C\t");            
            for (int k = 0; k < column; k++) Console.Write($"{k}\t");
            Console.ResetColor();
            Console.WriteLine("");
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){   
                if(j == 0) {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{i}\t");
                    Console.ResetColor();
                    }                     
                Console.Write(massivRnd[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }

        
    }
}