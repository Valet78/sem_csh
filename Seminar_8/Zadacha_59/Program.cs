/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7

P.S.: Программа убирает строку и столбец только первого попавшегося 
минимального значения.
*/


using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 4, massColumn = 5;        
        int [,] massivRnd = new int [massRow, massColumn];

        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("В заданном массиве: \n");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");
        int indexMinRow = 0, indexMinColumn = 0;
        int minElement = FoundMinimum (ref indexMinRow, ref indexMinColumn, massRow, massColumn);
        Console.WriteLine($"Наименьший элемент равен {minElement}, на выходе получим следующий массив:");
        MassivOutWithoutRC (indexMinRow, indexMinColumn, massRow, massColumn);        
        Console.WriteLine("");        

        int FoundMinimum (ref int indRow, ref int indColumn, int row, int column){
            int temp = massivRnd[0, 0];
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    if (massivRnd[i, j] < temp) {
                        temp = massivRnd[i, j];                        
                    }
                }
            }
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    if (massivRnd[i, j] == temp) {
                        temp = massivRnd[i, j];
                        indRow = i;
                        indColumn = j;
                        break;
                    }
                }
            }



            return temp;
        }

        void MassivOutWithoutRC (int indMinRow, int indMinColumn, int row, int column) {
            for(int i = 0; i < row; i++) {
                if (i == indMinRow) continue;
                for(int j = 0; j < column; j++){                                
                    if (j ==indMinColumn) continue;
                    else Console.Write(massivRnd[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }


        void MassivFillRnd(int row, int column){
            int minValue = 1, maxValue = 100;
            Random rndValue = new Random();                       
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
