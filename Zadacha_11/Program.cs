﻿// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//  456 -> 46
//  782 -> 72
//  918 -> 98

int num = new Random().Next(100, 999);
int sot = num / 100;
int edin = num % 10;
int result = sot * 10 + edin;
Console.WriteLine($"Из числа {num} убрали вторую цифру и получили {result}");