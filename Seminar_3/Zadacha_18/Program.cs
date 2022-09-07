using System;
public class MainClass
{
    
    public static void Main()
    {
        Console.Clear();
        
      // *********************  
        
        Console.Write("Введите номер четверти в системе координат: ");
        int?  chetv = Convert.ToInt16(Console.ReadLine());
               
        if (chetv > 0 && chetv < 5) {
            switch (chetv){
                case 1:
                    Console.WriteLine($"В {chetv} четверти располагаются точки с координатами, где \"x\" и \"y\" > 0");
                break;
                case 2:
                    Console.WriteLine($"В {chetv} четверти располагаются точки с координатами, где \"x\" < 0 и \"y\" > 0");
                break;
                 case 3:
                    Console.WriteLine($"В {chetv} четверти располагаются точки с координатами, где \"x\" и \"y\" < 0");
                break;
                case 4:
                    Console.WriteLine($"В {chetv} четверти располагаются точки с координатами, где \"x\" > 0 и \"y\" < 0");
                break;
            }

        }
          else Console.WriteLine("Введено недопустимое значение!");



        



    }
}


/*

Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).

*/
