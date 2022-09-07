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
        Console.Write("z1 = ");
        double  z1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("x2 = ");
        double  x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        double  y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("z2 = ");
        double  z2 = Convert.ToDouble(Console.ReadLine());        
               
        double rez = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1);
        rez = Math.Round(Math.Sqrt(rez), 2);
        Console.WriteLine($"Растояние между двумя точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {rez}");       

    }
}


/*

Задача 20: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.


A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


*/
