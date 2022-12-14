/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0



*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 4;                        // количество элементов в исходном массиве
            int [] mass = new int [len];
                                    
            RndMass(mass, len, 0, 100);  
            OutMass (mass, len); 
            Console.Write(" -> ");
            Console.WriteLine(ChetSum());
           
                       

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
            int ChetSum (){
                int res = 0;
                for(int i = 0; i < len; i++){
                    if (i % 2 != 0) res += mass[i];                  
                }
                return res;
            } 
            
    }           

}
    