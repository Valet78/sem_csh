/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

*/


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            int len = 7;                        // количество элементов в исходном массиве
            int [] mass_1 = new int [len];
            int len_2 = len / 2;
            if (len % 2 != 0) len_2++;
            int [] mass_2 = new int [len_2];
                        
            RndMass(mass_1, len, 0, 10);  
            Console.Write("[");
            OutMass (mass_1, len); 
            Console.Write("] -> ");
            MassProizv();
            OutMass (mass_2, len_2); 

                       

            //вывод массива
            void OutMass (int [] massiv, int size){
                string temp = "";
                for(int i = 0; i < size; i++){
                temp += massiv[i].ToString();
                if(i < size - 1) temp += " ";
                }
                Console.Write(temp);
                              
            }

            //заполнение массива
            void RndMass(int [] massiv, int size, int minValue, int maxValue){
                for(int i = 0; i < size; i++){
                massiv[i] = new Random().Next(minValue, maxValue);                
                }     
            }
                
            // изменение массива 
            void MassProizv (){
                int ind_s = 0, ind_f = len - 1;
                for(int i = 0; i < len_2; i++){
                    if (ind_s != ind_f) {
                        mass_2[i] = mass_1[ind_s] * mass_1[ind_f];
                        ind_s++; ind_f--;                        
                    }
                    else mass_2[i] = mass_1[ind_s];
                }
            } 
            
    }           

}
    