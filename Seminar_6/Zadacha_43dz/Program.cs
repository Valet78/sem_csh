/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, 
b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
using System;

public class MyClass{
    public static void Main(){
        Console.Clear();

        Console.WriteLine("Введите параметры уравнений для поиска точки пересечения двух прямых");
        Console.WriteLine("y = k1 * x + b1 и y = k2 * x + b2");
        string [] strMassLit = {"k1 = ", "k2 = ", "b1 = ", "b2 = "};        
        double [] massZnach = new double [4];           

        if (InputData (strMassLit)){
/*
Если система уравнений:
    имеет единственное решение, то прямые пересекаются;
    имеет бесконечное множество решений, то прямые совпадают;
    не имеет решений, то прямые не пересекаются (прямые параллельны между собой)
*/
        if (massZnach[0] != massZnach[1] && massZnach[2] != massZnach[3]) {
            double znachX = (massZnach[3] - massZnach[2]) / (massZnach[0] - massZnach[1]);
            double znachY = massZnach[0] * znachX + massZnach[2];
            
            Console.WriteLine($"k1 = {massZnach[0]}, b1 = {massZnach[2]}, k2 = {massZnach[1]}, b2 = {massZnach[3]} -> ({znachX}; {znachY})");

        }  else if(massZnach[2] == massZnach[3]) Console.WriteLine("Прямые совпадают. Имеется множество решений.");
        else  Console.WriteLine("Прямые параллельны. Точек пересечения нет.");         
        } 
        
        // Ввод данных в массив строк
        bool InputData (string [] massLit){
            bool res = false;
            string temp = "";
            for (int i = 0; i < 4; i++){
               Console.Write(massLit[i]);
                
               temp = Console.ReadLine() ?? "0";
                if(temp == "") {
                    Console.WriteLine("Забыли ввести число. Попробуйте снова");
                    i--;
                } else if(!TryInputText(temp, i)){
                    Console.WriteLine("Введено некорректное число. Попробуйте снова");
                    i--;
                } else res = true;
            } 
            return res;
        }

       // Проверка правильности ввода числа   
        bool TryInputText (string inputText, int index){
            bool tryRes = true;            
            if(!double.TryParse(inputText, out massZnach[index])) tryRes = false;                                  
            return tryRes;
        }
    }
}