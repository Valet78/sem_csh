/*

Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        int [] mass = new int [] {1, 2, 3, 4, 5};
        int lenMass = mass.Length;

        OutMass(mass, lenMass);
        Console.Write(" -> ");
        ReversMassive (mass, lenMass);
        OutMass(mass, lenMass);

        void ReversMassive (int [] massiv, int len_massiv){
            int backIndex = len_massiv - 1;
            int centr = len_massiv / 2;
            int temp = 0;            
            for(int i = 0; i < centr; i++){
                temp = massiv[i];
                massiv[i] = massiv[backIndex];
                massiv[backIndex] = temp;
                backIndex--;
            }
        }       

        void OutMass (int [] massiv, int len_massiv) {
            Console.Write("[");
            for (int i = 0; i < len_massiv; i++){
                Console.Write(massiv[i]);
                if (i<len_massiv - 1) Console.Write(" ");
            }
            Console.Write("]");
        }
    }
}
