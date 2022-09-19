/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        Console.WriteLine("Введите целое положительное число (количество чисел из последовательности Фибоначчи) для вывода:");
        Console.Write("N = ");
        string ? numberStr = Console.ReadLine();
        if (numberStr != ""){
            bool checkNumber = true;
            int numberInt = TryInputText(numberStr ?? "0", ref checkNumber);
            if (checkNumber) {
                int [] resultMass = new int [numberInt];
                Fibonachchi(numberInt, ref resultMass);
                Console.Write($"Если N = {numberInt} -> ");
                FibonachchiOut(numberInt, ref resultMass);
            } else Console.WriteLine("Введено некорректное число!");
        } else Console.WriteLine("Введено некорректное число!");

        // Проверка правильности ввода числа   
        int TryInputText (string InputText, ref bool chknum){
            int tryRes=0;
            if(!int.TryParse(InputText, out tryRes)) chknum = false;
            if(tryRes <= 0) chknum = false;
            return tryRes;
        }
        // Заполнение массива
        void Fibonachchi(int elem, ref int [] massiv){            
             for(int i = 0; i < elem; i++){
                if (i == 0) massiv[i] = 0;
                if (i == 1) massiv[i] = 1;
                if (i > 1) massiv[i] = massiv[i - 2] + massiv[i - 1];
             }           
        }
        // Вывод массива значений
        void FibonachchiOut(int elem, ref int [] massiv){
            for (int i = 0; i < elem; i++){
                Console.Write($"{massiv[i]} ");
            }
            Console.WriteLine("");
        }

    }
}
