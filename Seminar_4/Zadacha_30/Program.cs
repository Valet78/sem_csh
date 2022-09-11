/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]


*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int elem = 8;
            int [] number = new int [elem];

            for(int i=0; i < elem; i++){
                RndArray(i);
            }

            Console.Write("[");
            for (int i=0; i < elem; i++){
                Console.Write(number[i]);
                if (i<7) Console.Write(",");
            }
            Console.WriteLine("]");

            void RndArray(int ind){
                number[ind] = new Random().Next(0, 2);
            }               
    }           

}
    