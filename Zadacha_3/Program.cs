// Написать программу, которая будет выдавать названия дня недели по заданному номеру
// 3 -> среда
// 5 -> пятница


// Решение с использованием массивов
/*
string[] nedelya = new string[] {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};
int num = 0;
Console.Write("Введите номер дня недели (1..7): ");
num = Convert.ToInt16(Console.ReadLine());
if (num > 0 && num < 8) Console.WriteLine($"{num} день недели - это {nedelya[num - 1]}.");
    else Console.WriteLine("Такого дня недели не существует!");

*/

int num = 0;
string message = " ";
Console.Write("Введите номер дня недели (1..7): ");
num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1: 
            message = "понедельник";
        break;
        case 2:
           message = "вторник";
        break;
        case 3:
           message = "среда";
        break;
        case 4:
           message = "четверг";
        break;
        case 5:
           message = "пятница";
        break;
        case 6:
           message = "суббота";
        break;
        case 7:
           message = "воскресение";
        break;
        default:
           num = 0;
           Console.WriteLine("Введён номер несуществующего дня недели!");
        break;
    }
    if (num != 0) Console.WriteLine($"{num} день недели - это {message}.");
            
            
    
    



