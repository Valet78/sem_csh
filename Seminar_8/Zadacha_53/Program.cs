/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
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
        Console.WriteLine ("поменяем местами первую и последнюю строки массива:");
        Console.WriteLine("");
        
        ChangeRowInMassive(massRow, massColumn);
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");

        void ChangeRowInMassive(int row, int column){
            int tempValue = 0;
            row--;
            for (int i = 0; i < column; i++){
                tempValue = massivRnd[0, i];
                massivRnd[0, i] = massivRnd[row, i];
                massivRnd[row, i] = tempValue;
            }

        }

        void MassivFillRnd(int row, int column){
            Random rndValue = new Random();   
            int minValue = 1, maxValue = 100;         
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


