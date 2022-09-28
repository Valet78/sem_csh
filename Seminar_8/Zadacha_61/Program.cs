/*
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника.
*/

using System;

public class MainClass{
    public static void Main(){
        Console.Clear();

        Console.WriteLine("Введите количество строк треугольника Паскаля");
        int numInputN = inputNumRow();
        int [,] trianglPass = new int [numInputN, numInputN];

        FillTriangle();
        TriangleOutConsole ();

        
        
        void FillTriangle (){
            for (int i = 0; i < numInputN; i ++){
                trianglPass[i, 0] = 1;
                trianglPass[i, i] = 1;
            }
            for (int i = 2; i < numInputN; i ++){
                for (int j = 1; j < numInputN; j ++){
                    trianglPass[i, j] = 
                        trianglPass[i - 1, j - 1] +
                        trianglPass[i - 1, j];
                }
            }
        }

        void TriangleOutConsole (){
            int numSpace = 0;
            for (int i = 0; i < numInputN; i ++){
                for (int j = 0; j < i + 1; j ++){
                    numSpace = (numInputN - 1) - i;
                    if(j == 0) Console.Write(string.Concat(Enumerable.Repeat(" ", numSpace)));
                    Console.Write(trianglPass[i, j]);
                    if (trianglPass[i, j] < 10) Console.Write("  ");
                    else Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }       
       
       int inputNumRow(){
            int temp = 0;
            Console.Write("N = ");
            while (!TryInputText (Console.ReadLine() ?? String.Empty, ref temp)){
                Console.WriteLine("Введено некорректное число. Попробуйте снова.");
                Console.Write("N = ");
                temp = 0;
            }
            return temp;
       }

       // Проверка правильности ввода числа   
        bool TryInputText (string inputText, ref int inputInt){
            bool tryRes = true;            
            if(!Int32.TryParse(inputText, out inputInt)) tryRes = false; 
            if (inputInt <= 0)tryRes = false;                                
            return tryRes;
        }
    }
}