/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
            сумма положительных чисел равна 29, 
            сумма отрицательных равна -20.

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 12;
            int [] mass = new int [len];
            
            RndMass();   
            Console.WriteLine("В массиве:");
            OutMass ();

            Console.WriteLine($"Сумма положительных чисел равна {PositiveSum ()}");
            Console.WriteLine($"Сумма отрицательных чисел равна {NegativeSum ()}");

            //вывод массива
            void OutMass (){
                string temp = "[";
                for(int i = 0; i < len; i++){
                temp += mass[i].ToString();
                if(i < len - 1) temp += ", ";
                }
                Console.Write(temp + "]\n");                
            }

            //заполнение массива
            void RndMass(){
                for(int i = 0; i < len; i++){
                mass[i] = new Random().Next(-9, 10);                
                }     
            }

            // считаем сумму положительных чисел в массиве
            int PositiveSum (){
                int posit = 0;
                for (int i = 0; i < len; i ++){
                    if (mass[i] > 0) posit += mass[i];
                }
                return posit;
            }

            // ститаем сумму отрицательных чисел в массиве
            int NegativeSum(){
                int negat = 0;
                for (int i = 0; i < len; i ++){
                    if (mass[i] < 0) negat += mass[i];
                }
                return negat;
            }


    }           

}
    