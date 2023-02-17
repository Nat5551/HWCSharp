/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Введите положительное число:");
int a = Convert.ToInt32(Console.ReadLine());
int inx = 2;
if (a<=0) 
Console.WriteLine("Нужно ввести положительное число");
else
  {while(inx<=a)
     {Console.Write(inx + " ");
     inx = inx+2;}
  }
;
 

