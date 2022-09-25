/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 3, massColumn = 5;
        
        int [,] massivRnd = new int [massRow, massColumn];

        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("В заданном массиве: \n");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");
        Console.WriteLine ("поменяем местами строки со столбцами:");
        Console.WriteLine("");
        
        ChangeRowInColumn(massRow, massColumn);        
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");

        void ChangeRowInColumn(int row, int column){
            int tempValue = 0;            
            int rowNew = column, columnNew = row;            
            massRow = rowNew;
            massColumn = columnNew;             
            int [,] newArray = new int [rowNew, columnNew];

            for (int i = 0; i < rowNew; i++){
                for (int j = 0; j < columnNew; j++){                
                newArray[i, j] = massivRnd[j, i];
                }                
            }
            massivRnd = newArray;
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


