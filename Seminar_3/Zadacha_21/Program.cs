using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("x1 = ");
        double  x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1 = ");
        double  y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("x2 = ");
        double  x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        double  y2 = Convert.ToDouble(Console.ReadLine());
               
        double rez = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
        rez = Math.Round(Math.Sqrt(rez), 2);
        Console.WriteLine($"Растояние между двумя точками с координатами ({x1}, {y1}) и ({x2}, {y2}) равно {rez}");


        



    }
}


/*

Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/
