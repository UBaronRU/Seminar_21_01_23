// Показать таблиц
int Num1 = 0;
int Num2 = 0;
Console.Write("Введите число: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i < Num1+1; i++)
{
    Num2=i*i;
    Console.WriteLine("Квадрат числа "+ i +" -> "+Num2);
}