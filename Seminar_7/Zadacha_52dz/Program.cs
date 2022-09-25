/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 5, massColumn = 4;
        
        int [,] massivRnd = new int [massRow, massColumn];

        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("В заданном массиве: \n");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");
        Console.Write("Среднее арифметическое каждого столбца: ");
        EverageOutConsole(massRow, massColumn);
        
        
        
        void EverageOutConsole(int row, int column){
            double evarageValue = 0;
            string result = String.Empty;
            for(int i = 0; i < column; i++) {                
                for(int j = 0; j < row; j++){
                    evarageValue += (double) massivRnd[j, i] / row ;
                }
                evarageValue = Math.Round(evarageValue, 1);
                result += evarageValue.ToString();
                evarageValue = 0;
                if (i < column - 1) result += "; ";
            }
            Console.WriteLine(result + "\n");
        }          

        void MassivFillRnd(int row, int column){
            Random rndValue = new Random();   
            int minValue = 1, maxValue = 11;         
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                massivRnd[i, j] = rndValue.Next(minValue, maxValue);
                }
            }
        }

        void MassivOutConsole(int row, int column){             
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){                                
                Console.Write(massivRnd[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }        
    }
}


