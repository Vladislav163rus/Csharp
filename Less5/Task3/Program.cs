// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double []array =new double [new Random().Next(4 ,5)];
for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(0,100);
      Console.WriteLine($"{array[i]}");
}
double min=array[0];
double max=array[0];
double a=0;
foreach(var item in array)
{
    if (min>item)
    min=item;
    if (max<item)
    max=item;
    a=(max-min);
}

Console.WriteLine("разница между максимальным и минимальным значением составляет " + a);
