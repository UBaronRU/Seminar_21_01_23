// See https://aka.ms/new-console-template for more information
int [] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine("Элемент массива №" + i + " -> "+array[i]);
}
