// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число дня недели");
int x=Convert.ToInt32 ( Console. ReadLine());
if (x==1) Console.WriteLine("Рабочий день"); 
else if (x==2) Console.WriteLine("Рабочий день"); 
else if (x==3) Console.WriteLine("Рабочий день");
else if (x==4) Console.WriteLine("Рабочий день"); 
else if (x==5) Console.WriteLine("Рабочий день"); 
else if (x==6) Console.WriteLine("Выходной день"); 
else if (x==7) Console.WriteLine("Выходной день");
else Console.WriteLine("Вы ввели не то число");