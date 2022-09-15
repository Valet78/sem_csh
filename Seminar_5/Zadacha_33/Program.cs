/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
 
 4; массив [6, 7, 19, 345, 3] -> нет
 3; массив [6, 7, 19, 345, 3] -> да


*/ 


using System;

public class MainClass {
    public static void Main(){
            Console.Clear();
            
            int [] mass = new int [] {6, 7, 19, 345, 3};
            int len = mass.Length;
            bool tryText = true;
            int fnum = 0;
            bool res_f = true;            
 
            Console.WriteLine("Введите число для проверки наличия его в случайном массиве:");
            string ? num_str = Console.ReadLine();
            if (num_str != ""){
                fnum = TryInputText(num_str, ref tryText);
                if(tryText){                   
                   Console.Write($"{fnum}; массив ");
                   OutMass ();
                   Console.Write(" -> ");
                   res_f = SearchToMass(fnum);
                   if(res_f) Console.Write("да");
                   else Console.Write("нет");
                }
                else Console.WriteLine("Введено некорректное число!");                
            }
             else Console.WriteLine("Введено некорректное число!");

            // Проверка ввода числа
            int TryInputText (string ? inputText, ref bool tryText){
                int try_res=0;
                if(!int.TryParse(inputText, out try_res)) tryText = false;
                return try_res;
            }            

            //вывод массива
            void OutMass (){
                string temp = "[";
                for(int i = 0; i < len; i++){
                temp += mass[i].ToString();
                if(i < len - 1) temp += ", ";
                }
                Console.Write(temp + "]");                
            }
            
            // поиск числа в массиве
            bool SearchToMass (int num_f){
                bool result = true;
                for (int i = 0; i < len; i++){
                    if (mass[i] == num_f) {
                        result = true;
                        break;
                    }
                    else result = false;
                }    
                return result;                            
            }
    }           
}

