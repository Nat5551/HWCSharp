/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 || a>=1000) 
  Console.WriteLine("Нужно ввести трехзначное число!");
else 
  Console.WriteLine($"Вторая цифра: {a/10 %10}");  




