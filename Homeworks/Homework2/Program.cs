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
void FindThirdDigit(int[] array)
{  int n = array.Length;
   int index = 0; 
   {
      while (index < 2)
      {
         Console.WriteLine("Here is no third digit of this number ");
      }
      index++;
      if (index == 2)
      {
         Console.WriteLine($"Here is the third digit of this number");
      }
   }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(number);
Console.WriteLine(new_digit);
*/


int FindNewDigit ([]int number, int third_digit)
{
   int digits = number.Lenght;
   int index = 0;





}

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