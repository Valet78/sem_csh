/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

    Набор данных                  Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }      0 встречается 2 раза
                                1 встречается 1 раз
                                2 встречается 1 раз
                                8 встречается 1 раз
                                9 встречается 3 раза

1, 2, 3                         1 встречается 3 раза
4, 6, 1                         2 встречается 2 раз
2, 1, 6                         3 встречается 1 раз
                                4 встречается 1 раз
                                6 встречается 2 раза
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int massRow = 4, massColumn = 5;
        int minValue = 0, maxValue = 10;
        int [,] massivRnd = new int [massRow, massColumn];

        MassivFillRnd(massRow, massColumn, minValue, maxValue);
        Console.WriteLine("В заданном массиве: \n");
        MassivOutConsole(massRow, massColumn);
        Console.WriteLine("");
        FoundNumberInMassiv (massRow, massColumn, minValue, maxValue);
        Console.WriteLine("");
        

        void FoundNumberInMassiv (int rowIn, int columnIn, int minIn, int maxIn){
            int numFound = 0;            
            for (int num = minIn; num < maxIn; num++){
                numFound = NumberOfDigitsIn (rowIn, columnIn, num);
                if (numFound != 0){
                    Console.Write($"{num} встречается {numFound} ");
                    if (numFound == 2 || numFound == 3 || numFound == 4)  Console.WriteLine("раза");
                    else Console.WriteLine("раз");
                }
            }
        }

        int NumberOfDigitsIn (int row, int column, int number){
            int temp = 0;
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    if (massivRnd[i, j] == number) temp ++;
                }
            }
            return temp;
        }


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
                Console.Write(massivRnd[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }        
    }
}
