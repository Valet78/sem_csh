/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.

1 4 8 19
5 -2 33 -2
77 3 8 1
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        int massRow = 3, massColumn = 4;
        int minValue = -100, maxValue = 101; 

        int [,] massivRnd = new int [massRow, massColumn];
        MassivFillRnd(massRow, massColumn, minValue, maxValue);
        MassivOutConsole(massRow, massColumn);


        void MassivFillRnd(int row, int column, int min, int max){
            var rndValue = new Random();            
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                massivRnd[i, j] = rndValue.Next(min, max);
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
        
    }
}