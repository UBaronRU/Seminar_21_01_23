int Num1; // Основное число
int Num_rzd; // Разрядность основного числа
Num_rzd = 1;
string [] array = {"разрядов","разряд","разряда","разряда","разряда","разрядов","разрядов","разрядов","разрядов","разрядов",};
string okonchanie= "";
Console.Write("Введите число  : ");
Num1 = int.Parse(Console.ReadLine());
// Определяем количество разрядов в числе
// Мы нашли k грибов
while (Num1 / Math.Pow(10,Num_rzd) > 1 & Num_rzd < 10)
{
Num_rzd = Num_rzd + 1; 
}
okonchanie = array [Num_rzd%10];
Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " "+okonchanie);
