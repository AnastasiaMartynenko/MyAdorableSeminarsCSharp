// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first digit: ");
int first_digit = Convert.ToInt32(Console.ReadLine());

int a = first_digit;


Console.WriteLine("Input second digit: ");
int second_digit = Convert.ToInt32(Console.ReadLine());
int b = second_digit;

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



