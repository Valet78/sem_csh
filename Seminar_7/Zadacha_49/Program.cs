/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
чётные, и замените эти элементы на их квадраты.

Например, изначально массив         Новый массив будет выглядеть
          выглядел вот так:         вот так:                    
          1 4 7 2                   1 4 7 2
          5 9 2 3                   5 81 2 9
          8 4 2 4                   8 4 2 4

*/


using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        int massRow = 5, massColumn = 5;
        int minValue = 1, maxValue = 10; 

        int [,] massivRnd = new int [massRow, massColumn];
        MassivFillRnd(massRow, massColumn, minValue, maxValue);
        Console.WriteLine("Исходный массив выглядит так:");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine();
        Console.WriteLine("Новый массив выглядит так:");
        MassivChangeElements(massRow, massColumn);
        MassivOutConsole(massRow, massColumn);

        void MassivFillRnd(int row, int column, int min, int max){
            Random rndValue = new Random();            
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

        void MassivChangeElements(int row, int column){
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                    if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0){
                        massivRnd[i, j] =  massivRnd[i, j] * massivRnd[i, j];
                    }                 
                }
            }
        }
        
    }
}


