/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        int rowAndcolumn = 4;
        int [,] massSpiral = new int [rowAndcolumn, rowAndcolumn];
        FillMassSpiral(rowAndcolumn);
        MassOutInConsole(rowAndcolumn);
        Console.WriteLine("");

        // Заполнение массива
        void FillMassSpiral(int rc){
            int numer = 1;
            int krat = (rc % 2 == 0) ? rc : rc + 1;
            for (int i = 0; i < krat; i++){
                numer = FillAroundMass(i, rc - i, numer);    
            }
        }

        // Обход по спирали массива
        int FillAroundMass(int indRun, int indStop, int num){
            for(int i = indRun; i < indStop; i++) {
                massSpiral[indRun, i] = num;
                num++;
            }
            for(int j = indRun + 1; j < indStop - 1; j++) {
                massSpiral[j, indStop - 1] = num;
                num++;
            }
            for(int k = indStop - 1; k > indRun; k--) {
                massSpiral[indStop - 1, k] = num;
                num++;
            }
            for(int l = indStop - 1; l > indRun; l--) {
                massSpiral[l, indRun] = num;
                num++;
            }
            return num;
        }

        // Вывод массива в консоль
        void MassOutInConsole(int rc){
            for (int i = 0; i < rc; i++){
                for (int j = 0; j < rc; j++){
                    Console.Write(massSpiral[i, j] + "\t");
                }
                Console.WriteLine("");
            }

        }
    }
}