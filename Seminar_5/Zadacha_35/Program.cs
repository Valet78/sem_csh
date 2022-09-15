/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5


*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 123;
            int [] mass = new int [len];
            int resToRange = 0;
            
            RndMass();   
            OutMass ();            
            Console.Write(" -> ");
            Console.WriteLine (IntToRange ());
                       

            //вывод массива
            void OutMass (){
                string temp = "[";
                for(int i = 0; i < len; i++){
                temp += mass[i].ToString();
                if(i < len - 1) temp += ", ";
                }
                Console.Write(temp + "]");                
            }

            //заполнение массива
            void RndMass(){
                for(int i = 0; i < len; i++){
                mass[i] = new Random().Next(250);                
                }     
            }

            // изменение массива 
            int IntToRange (){
                int res = 0;
                for (int i = 0; i < len; i ++){                
                    if (mass[i] > 9 && mass[i] < 100) res++;
                }                
                return res;
            }
    }           

}
    