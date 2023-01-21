int Num1; // Основное число

int Num_rzd; // Разрядность основного числа
Num_rzd = 1;
Console.Write("Введите число  : ");
Num1 = int.Parse(Console.ReadLine());
// Определяем количество разрядов в числе
// Мы нашли k грибов
while (Num1 / Math.Pow(10,Num_rzd) > 1 & Num_rzd < 10)
{
Num_rzd = Num_rzd + 1; 
}
switch (Num_rzd)
{
   case 1:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разряд");break;}
   case 2:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разряда");break;}
   case 3:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разряда");break;}
   case 4:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разряда");break;}
   case 5:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разрядов");break;}
   case 6:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разрядов");break;}
   case 7:  {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разрядов");break;}
   default: {Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " разряда");break;}
}