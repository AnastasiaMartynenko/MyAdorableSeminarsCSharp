/*
//Задача 1
int num;
Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

/*
//Задача 2. Напишите программу, где ользователь должен ввести число, а программа напечатать квадрат этого числа.

int num;
Console.WriteLine("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

int square = num * num;

Console.WriteLine("The square of " + num + " is " + square);
Console.WriteLine($"The square of {num} is {square}");
*/

//Задача 3. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square2 = number2 * number2;

if(number1 == square2)
{
    Console.WriteLine($"{number1} is a quarde of {number2}");

}
else
{
    Console.WriteLine($"{number1} is not a square of {number2}");
}
