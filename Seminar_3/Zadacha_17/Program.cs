using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.WriteLine("Введите координаты точки (где X ≠ 0 и Y ≠ 0)");
        Console.Write("x = ");
        int?  x = Convert.ToInt16(Console.ReadLine());
        Console.Write("y = ");
        int?  y = Convert.ToInt16(Console.ReadLine());
        
        if (x != 0 && y != 0) {
            if (x > 0 && y > 0){
                  Console.WriteLine($"Точка с координатами ({x}, {y}) находится в первой четверти");
             }
            if (x < 0 && y > 0){
                  Console.WriteLine($"Точка с координатами ({x}, {y}) находится во второй четверти");
             }
            if (x < 0 && y < 0){
                  Console.WriteLine($"Точка с координатами ({x}, {y}) находится в третьей четверти");
             }
            if (x > 0 && y < 0){
                  Console.WriteLine($"Точка с координатами ({x}, {y}) находится в четвёртой четверти");
             }

        }
          else Console.WriteLine("Введено недопустимое значение!");



        



    }
}


/*

Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.

*/

