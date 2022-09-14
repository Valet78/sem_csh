/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int [] mass = new int [8];
            
            RndMass();    
            OutMass ();

            //вывод массива
            void OutMass (){
                string temp = "[";
                for(int i = 0; i < 8; i++){
                temp += mass[i].ToString();
                if(i < 7) temp += ", ";
                }
                Console.Write(temp + "]");                
            }

            //заполнение массива
            void RndMass(){
                for(int i = 0; i < 8; i++){
                mass[i] = new Random().Next(100);                
                }     
            }
    }           

}
    