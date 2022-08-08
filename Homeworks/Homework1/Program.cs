/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input the first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());

int a = first_number;


Console.WriteLine("Input the second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

int b = second_number;

int max = a;
int min = b;

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
    

Console.WriteLine($"Max of these two numbers is {max}");

*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int a = number1;


Console.WriteLine("Input the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int b = number2;


Console.WriteLine("Input the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int c = number3;

int max = a;

if( b > max)
{
    max = b;
}
else
{
    max = c;
}
    
Console.WriteLine($"The max of these three numbers is {max}");

*/
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0) 
{
 Console.WriteLine($"{number} is an even number");
}


if(number%2 > 0)
{
 Console.WriteLine($"{number} is not an even number");
}











