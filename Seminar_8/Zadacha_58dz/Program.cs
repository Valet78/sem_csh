/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRowCol = 3;        
        
        int [,] massivRndOne = new int [massRowCol, massRowCol];
        int [,] massivRndTwo = new int [massRowCol, massRowCol];
        int [,] massivRezult = new int [massRowCol, massRowCol];

        MassivFillRnd(massivRndOne, massRowCol);
        MassivFillRnd(massivRndTwo, massRowCol);
        Console.WriteLine("Заданы два массива: ");
        Console.WriteLine("");       
        MassivOutConsole(massivRndOne, massRowCol);
        Console.WriteLine(String.Concat(Enumerable.Repeat("-", massRowCol * 6)));       
        MassivOutConsole(massivRndTwo, massRowCol);
        Console.WriteLine(""); 
        Console.WriteLine("Результатом перемножения их будет матрица: \n");          
        MassivResultFill(massRowCol);
        MassivOutConsole (massivRezult, massRowCol);
        Console.WriteLine("");


        void MassivResultFill(int rowCol){
            // int rc = 0;
            for(int i = 0; i < rowCol; i ++){
                for (int j = 0; j < rowCol; j ++){
                    for(int rc = 0; rc < rowCol; rc ++){
                    massivRezult[i, j] += massivRndOne[i, rc] * massivRndTwo[rc, j];
                    //rc++;
                    }
                }
                //rc = 0;
            }
        }

        void MassivFillRnd(int [,] massTemp, int rowCol){
            Random rndValue = new Random();   
            int minValue = 1, maxValue = 10;         
            for(int i = 0; i < rowCol; i++) {
                for(int j = 0; j < rowCol; j++){
                massTemp[i, j] = rndValue.Next(minValue, maxValue);
                }
            }
        }

        void MassivOutConsole(int [,] massTemp, int rowCol){
            for(int i = 0; i < rowCol; i++) {
                for(int j = 0; j < rowCol; j++){                                
                Console.Write(massTemp[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }        
    }
}
