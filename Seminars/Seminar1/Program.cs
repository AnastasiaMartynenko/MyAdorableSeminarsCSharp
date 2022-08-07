/*
//Задача 1
int num;
Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

//Задача 2. Пользователь должен ввести число, а программа напечатать квадрат этого числа.

int num;
Console.WriteLine("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

int square = num * num;

Console.WriteLine("The square of " + num + " is " + square);
Console.WriteLine($"The square of {num} is {square}");

