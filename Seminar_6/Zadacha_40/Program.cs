/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.

P.S.: Чтобы треугольник существовал, сумма двух сторон треугольника всегда должна быть 
      больше третей стороны. a + b > c, b + c > a, a + c > b.

*/

using System;

public class MainClass{
    public static void  Main(){
        Console.Clear();

        Console.WriteLine("Введите три целых числа (длины сторон треугольника):");
        Console.Write("сторона А = ");
        string ? storAStr = Console.ReadLine();
        Console.Write("сторона B = ");
        string ? storBStr = Console.ReadLine();
        Console.Write("сторона C = ");
        string ? storCStr = Console.ReadLine();

        if (storAStr != "" && storBStr != "" && storCStr != ""){
            int storA = TryInputText(storAStr ?? "0");
            int storB = TryInputText(storBStr ?? "0");
            int storC = TryInputText(storCStr ?? "0");

            if(storA > 0 && storB > 0 && storC > 0){
                if(CheckTriangle(storA, storB, storC)) {
                    Console.WriteLine("Треугольник с такими сторонами имеет право на существование. Условия соблюдены.");
                } else Console.WriteLine("Треугольник с такими сторонами существовать не может!");
            } else Console.WriteLine("Введено некорректное число!");
        } else Console.WriteLine("Введено некорректное число!");


        // Проверка правильности ввода числа   
        int TryInputText (string InputText){
            int tryRes=0;
            if(int.TryParse(InputText, out tryRes)){ 
                if(tryRes < 1) tryRes = -1;
            } else tryRes = -1;
            return tryRes;
        }

        // Проверка условий существования треугольника с заданными сторонами
        bool CheckTriangle (int first, int second, int third){
            bool result = false;
            if(first + second > third && second + third > first && first + third > second){
                result = true;
            }
            return result;
        }


    }
}