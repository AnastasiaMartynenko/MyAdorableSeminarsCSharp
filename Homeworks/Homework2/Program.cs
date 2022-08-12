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
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThirdDigit(int[]array)

{  
   array = new Random();
   int index = 0; 
   {
      while (index < 2)
      {
         Console.WriteLine("Here is no third digit of this number ");
      }
      index++;
      if (index == 2)
      {
         Console.WriteLine($"Here is the third digit of this number ");
      }
   }
}
Console.Write("Input a number: ");
int random_number = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(random_number);
Console.WriteLine(new_digit);

*/
/*
int FindThirdDigit ([]int array)
{
  
  for(int index < 2; index <array.Length; index++)

  




}

 //int index = 0;
 //  third_number = number[2];

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int new_number = FindThirdDigit(number);
Console.WriteLine(new_digit);



void FindThirdNumber(int[] number)
{ int length = number.Lenght;
  int index = 0;
  while(index < 2)
   {
      Console.WriteLine("Here is no third digit of this number ");
      number[index] = new Random();
      index++;
      
   }

}  
   
  FindThirdNumber(number);
  PrintArray(number);
   
   /*
   Console.WriteLine("Here is no third digit of this number ");
   
   while(index < 2)
   {
      
      index++;
   }
        if(index == 2)
   {
      Console.WriteLine("Here is no third digit of this number ");
   }

}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(number);
Console.WriteLine(new_digit);


/*
int third_number;
int index = 0;
{
   if(index < 0)
   {
      Console.WriteLine("Here is no third digit of this number ");
   }
   index ++;
   if(index == 2)
   {
      Console.WriteLine("Here is the third digit of this number");
   }  
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(number);
Console.WriteLine(new_digit);


int third_digit = array[2]; 
*/

/*
int FindThirdDigit ([]int array)
{
  for(int index < 2; index <array.Length; index++)
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool FindWeekend (int day_number)
{
   if(day_number >= 6)
      return true;
   
   else
      return false;
}
Console.Write("Input any number of a week day: ");
int day_number = Convert.ToInt32(Console.ReadLine());

bool FindDay = FindWeekend(day_number);
Console.WriteLine(FindDay);
*/

//// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*
int FindThirdDigit(int[]array)

{  
   int third_digit = array[2];
   int random_number = Convert.ToInt32(new Random());
   int index = 0; 
   {
      while (index < 2)
      {
         Console.WriteLine("Here is no third digit of this number ");
      }
      index++;
      if (index == 2)
      {
         Console.WriteLine($"Here is the third digit of this number ");
      }
   }
}
Console.Write("Input a number: ");
int random_number = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(third_digit);
Console.WriteLine(new_digit);

*/