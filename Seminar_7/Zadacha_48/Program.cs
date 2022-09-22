/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        int massRow = 3, massColumn = 4;
        
        int [,] massivMain = new int [massRow, massColumn];
        MassivFill(massRow, massColumn);
        MassivOutConsole(massRow, massColumn);


        void MassivFill(int row, int column){                        
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                massivMain[i, j] = i + j;
                }
            }
        }
        void MassivOutConsole(int row, int column){
            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++){
                Console.Write(massivMain[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        
    }
}