/*
Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 3, massColumn = 4;          
        double [,] massivRnd = new double [massRow, massColumn];
        MassivFillRnd(massRow, massColumn);
        MassivOutConsole(massRow, massColumn);


        void MassivFillRnd(int row, int column){
            Random rndValueInt = new Random();   
            Random rndValueDouble = new Random();
            int minValue = - 10, maxValue = 10;
            double temp =  0;                
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){               
                temp = rndValueInt.Next(minValue, maxValue) + rndValueDouble.NextDouble();
                massivRnd[i, j] = Math.Round(temp, 1);
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