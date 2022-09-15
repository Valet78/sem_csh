/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76



*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 4;                        // количество элементов в исходном массиве
            double [] mass = new double [len];
                                    
            RndMass(mass, len, 0, 100);  
            OutMass (mass, len); 
            Console.Write(" -> ");
            Console.WriteLine(RaznMinMax());
           
                       

            //вывод массива
            void OutMass (double [] massiv, int size){
                string temp = "[";
                for(int i = 0; i < size; i++){
                temp += massiv[i].ToString();
                if(i < size - 1) temp += ", ";
                }
                Console.Write(temp + "]");
                              
            }

            //заполнение массива
            void RndMass(double [] massiv, int size, int minValue, int maxValue){
                int temp = 0;
                for(int i = 0; i < size; i++){
                    temp = new Random().Next(minValue, maxValue);
                    massiv[i] = Convert.ToDouble(temp);                
                }     
            }
                
            // изменение массива 
            double RaznMinMax (){
                //double res = 0;
                int minInd = 0, maxInd = 0;
                double max = mass[0];
                double min = max; 
                for(int i = 0; i < len; i++){
                    if (mass[i] < min) {
                        min = mass[i]; 
                        minInd = i;
                    }              
                    if (mass[i] > max) {
                        max = mass[i];
                        maxInd = i;
                    }  
                }
                return mass[maxInd] - mass[minInd];
            } 
            
    }           

}
    