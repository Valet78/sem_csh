/*
Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 


*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 4;
            int [] mass = new int [len];
            
            RndMass();               
            OutMass ();
            Console.Write(" -> ");
            ChangeMass();
            OutMass ();
            

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
                mass[i] = new Random().Next(-9, 10);                
                }     
            }

            // изменение массива 
            void ChangeMass (){
                for (int i = 0; i < len; i ++){
                    if (mass[i] != 0) mass[i] = - mass[i];
                }                
            }
    }           

}
    