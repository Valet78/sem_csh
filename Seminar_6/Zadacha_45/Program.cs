/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.

*/
using System;

public class MainClass {
    public static void Main(){
        Console.Clear();
        int lenMass = 8;
        int [] inMass = new int [lenMass];
        int [] copyMass = new int [lenMass];
        RndMass(lenMass, max: 100);
        Console.WriteLine("Исходный массив:");
        MassOut(inMass, lenMass);
        Console.WriteLine("его копия:");
        MassCopy(inMass, copyMass);
        MassOut(copyMass, lenMass);


        void RndMass(int len, int max, int min = 0){
            for(int i = 0; i < len; i++){
            inMass[i] = new Random().Next(min, max);                
            }     
        }

        void MassOut (int [] mass, int len){
            for (int i = 0; i < len; i++){
                Console.Write($"{mass[i]} ");
            } 
            Console.WriteLine("");
        }

        void MassCopy (int [] inMass, int [] copyMass){
            for (int i = 0; i< inMass.Length; i++){
                copyMass[i] = inMass[i];
            }
        }

    }
}
