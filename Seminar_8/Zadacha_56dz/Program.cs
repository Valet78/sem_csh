/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 5, massColumn = 4;
        
        int [,] massivRnd = new int [massRow, massColumn];
        int [] sumInRow = new int [massRow];
        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("Задан массив: \n");
        MassivOutConsole(massRow, massColumn);
        Console.Write("\n Строка с наименьшей суммой элементов: ");
        FillMassSum (massRow, massColumn);
        MassSumOutInConsole();
              
        


        void FillMassSum (int row, int column){                       
            for (int i = 0; i < row; i ++) sumInRow[i] = SummaElementsInRow (i, column);            
        }

        void MassSumOutInConsole(){  
            int len = sumInRow.Length;
            int minimum = sumInRow[0];
            int [] minSumRow = new int [1]{0};
            int indexMin = 0;
            for (int i = 0; i < len; i ++){
                if(minimum > sumInRow[i]) minimum = sumInRow[i];
            }
            
            for (int j = 0; j < len; j ++){
                if(sumInRow[j] == minimum) {
                    if(minSumRow.Length != indexMin + 1) Array.Resize(ref minSumRow, minSumRow.Length + 1);
                    minSumRow[indexMin] = j + 1;
                    indexMin ++;   
                }
            } 
            for(int k = 0; k < indexMin; k++){
                Console.Write($"{minSumRow[k]}");
                if(k < indexMin - 1) Console.Write(", ");
            }              
        }
        

        int SummaElementsInRow (int row, int column){
            int summ = 0;
            for (int i = 0; i < column; i++){
                summ += massivRnd[row, i];
            }
            return summ;
        }

        void MassivFillRnd(int row, int column){
            Random rndValue = new Random();   
            int minValue = 1, maxValue = 10;         
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
