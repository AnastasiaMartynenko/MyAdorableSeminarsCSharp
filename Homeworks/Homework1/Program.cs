// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first digit: ");

Console.WriteLine("Input second digit: ");


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


int min = a;
int max = b;

if( a > b ) 
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
    

Console.WriteLine($"Max number of these two is {max}");



