/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 20;                        // количество элементов в исходном массиве
            int [] mass = new int [len];
                                    
            RndMass(mass, len, 100, 1000);  
            OutMass (mass, len); 
            Console.Write(" -> чётных чисел в массиве ");
            Console.WriteLine(Chet());
           
                       

            //вывод массива
            void OutMass (int [] massiv, int size){
                string temp = "[";
                for(int i = 0; i < size; i++){
                temp += massiv[i].ToString();
                if(i < size - 1) temp += ", ";
                }
                Console.Write(temp + "]");
                              
            }

            //заполнение массива
            void RndMass(int [] massiv, int size, int minValue, int maxValue){
                for(int i = 0; i < size; i++){
                massiv[i] = new Random().Next(minValue, maxValue);                
                }     
            }
                
            // изменение массива 
            int Chet (){
                int res = 0;
                for(int i = 0; i < len; i++){
                    if (mass[i] % 2 == 0) res++;                  
                }
                return res;
            } 
            
    }           

}
    