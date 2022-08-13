// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int MiddleDigit (int number)
{
   int dec = number / 10 % 10;
   return dec;
}
int randomNumber = new Random().Next(100,1000);
int newNumber = MiddleDigit(randomNumber);

*/
/*
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Input a number: ");

int number = Convert.ToInt32(Console.ReadLine());


for(int current_number = number; current_number >=1000; current_number++)
{
  current_number = number / 10 % 10;
  Console.WriteLine($"{current_number} is the third digit of {number}");
    if(current_number <= 999 && current_number >= 100)
    {
        current_number++;
        current_number = number % 10;
        Console.WriteLine($"{current_number} is the third digit of {number}");
    }
    
   
}
for (int current_number = number; current_number < 99; current_number++)
{
  Console.WriteLine($"{number} doesn't contain the third digit");
}
*/
