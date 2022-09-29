/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        int rc = 3;
        int [,,] mayMassiv = new int [rc, rc, rc];
        MassivFillRnd (rc);
        MassivOutConsole (rc);
        Console.WriteLine("");


        // Заполнени массива уникальными значениями
        void MassivFillRnd (int index){
            Random numForMassiv = new Random();
             int temp = 0;
            for(int z = 0; z < index; z++){
                for(int i = 0; i <index; i++){
                    for(int j = 0; j < index; j++){
                        temp = numForMassiv.Next(10, 100);
                        if (ValidRndInMassiv(temp, index)){
                         mayMassiv[i, j, z] = temp;
                        } else j--;                
                    }
                }
            }
        }

        // Проверка уникальности случайного числа в массиве
        bool ValidRndInMassiv(int num, int elem){
            bool tryNum = true;
            for(int z = 0; z < elem; z++){
                for(int i = 0; i < elem; i++){
                    for(int j = 0; j < elem; j++){
                        if (mayMassiv[i, j, z] == num) tryNum = false;                                          
                    }
                }
            }
            return tryNum;
        }


        // Вывод массива в консоль
        void MassivOutConsole (int index){
            for(int z = 0; z < index; z++){
                for(int i = 0; i <index; i++){
                    for(int j = 0; j < index; j++){                    
                        Console.Write($"{mayMassiv[i, j, z]} ({i}, {j}, {z})");
                        Console.Write("\t");
                    }
                    Console.WriteLine(" ");
                }
            }
        }


    }
}