/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 5, massColumn = 4;
        
        int [,] massivRnd = new int [massRow, massColumn];

        MassivFillRnd(massRow, massColumn);
        Console.WriteLine("Задан массив: \n");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("\n Выставим элементы по убывнию в каждой строке:");
        Console.WriteLine("");
        SetElementsInDescending (massRow, massColumn);
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");


        void SetElementsInDescending (int row, int column){
            //Console.WriteLine(row + " & " + column);
            for (int i = 0; i < row; i ++){
                SortMassInDescending(i, column);
            }
        }

        void SortMassInDescending(int row, int column){
            int temp = 0;            
            for (int i = 0; i < column; i++){               
                for(int k = 0; k < column - 1; k ++){                    
                    if(massivRnd[row, k] < massivRnd[row, k + 1]){
                        temp = massivRnd[row, k];
                        massivRnd[row, k] = massivRnd[row, k + 1];
                        massivRnd[row, k + 1] = temp;
                    }                     
                }
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
