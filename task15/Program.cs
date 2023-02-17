/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


*/
Console.WriteLine("Введите день недели (число от 1 до 7):");
int a = Convert.ToInt16(Console.ReadLine());
if (a<0 || a>7)
Console.WriteLine("Это не день недели");
else 
  { if (a ==6)
     Console.WriteLine("Да, выходной! Суббота!");
    else if (a ==7) 
     Console.WriteLine("Да, выходной! Воскресенье!!!");
    else  Console.WriteLine("Нет,рабочий день!");
  }
