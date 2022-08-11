// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int MiddleDigit (int number)
{
   int dec = number / 10 % 10;
   return dec;
}
int randomNumber = new Random().Next(100,1000);
int newNumber = MiddleDigit(randomNumber);
Console.WriteLine($"{newNumber} is a middle digit of {randomNumber}");