/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12

*/


using System;

public class MainClass
{
    public static void Main()
    {
        Console.Clear();
        int massRow = 3, massColumn = 3;
        int minValue = 1, maxValue = 10;

        int[,] massivRnd = new int[massRow, massColumn];
        MassivFillRnd(massRow, massColumn, minValue, maxValue);
        Console.WriteLine("Задан массив:");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine();
        Console.Write("Сумма элементов главной диагонали: ");
        Console.WriteLine(SumElementDiagonal (massRow, massColumn));
        Console.WriteLine();
        
        void MassivFillRnd(int row, int column, int min, int max)
        {
            Random rndValue = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    massivRnd[i, j] = rndValue.Next(min, max);
                }
            }
        }
        void MassivOutConsole(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(massivRnd[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        int SumElementDiagonal (int row, int column){
            int result = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(i == j) result += massivRnd[i, j];
                }
            }
            return result;
        }
    }
}


