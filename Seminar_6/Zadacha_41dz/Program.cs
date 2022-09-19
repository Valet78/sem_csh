/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();
        bool checkNum = true;
        Console.WriteLine("Введите целые числа (для прекращения ввода введите \"Q\"");
        string ? numStr = " ";
        int [] numMass = new int [1];

        while (numStr != "Q"){
            numStr = Console.ReadLine();
            if (numStr != "" && numStr != "Q"){
                int numInt = TryInputText (numStr ?? "0", ref checkNum);
                if (checkNum){
                    FillMass(ref numMass, numInt);                    
                } else Console.WriteLine("Введено некорректное число!");
            } else if (numStr != "Q") Console.WriteLine("Забыли ввести число? Попробуйте снова.");            
        }
            MassOut(numMass);
            Console.WriteLine($" -> {PozitNum(numMass)}");


        // Заполнение массива 
        void FillMass(ref int [] mass, int value){
            int len = mass.Length;
            mass[len - 1] = value;
            Array.Resize(ref mass, ++len);            
        }

        // Проверка правильности ввода числа   
        int TryInputText (string inputText, ref bool chknum){
            int tryRes = 0;
            chknum = true;
            if(!int.TryParse(inputText, out tryRes)) chknum = false;                                  
            return tryRes;
        }

        void MassOut(int [] mass){
            int len = mass.Length - 1;
            for(int i = 0; i < len; i++){
                Console.Write(mass[i]);
                if (i < len - 1) Console.Write(", ");
            }
        }

        int PozitNum(int [] massiv){
            int len = massiv.Length - 1;
            int res = 0;
            for(int i = 0; i < len; i++){
                if (massiv[i] > 0) res++;
            }
            return res;
        }
    }
}







