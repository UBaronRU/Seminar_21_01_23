// See https://aka.ms/new-console-template for more information
//int[] arr = new int[8];
//foreach (int step in arr)
//{
//
//}
// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива
int [] array = new int[12];
int sum_plus = 0;
int sum_minus = 0;
// Заполнение
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(0,9);
}
// Расчет
for (int i = 0; i < 12; i++)
{
    if (array[i] > 0) 
    {
       sum_plus = sum_plus + array[i];
    }
     else
     {
        sum_minus = sum_minus + array[i];
     }
}

// Вывод результата
foreach (int step in array)
{
    Console.WriteLine("Элемент массива " + array[step]);
}
Console.WriteLine("Сумма положительных чисел " + sum_plus);
Console.WriteLine("Сумма отрицательных чисел " + sum_minus);
