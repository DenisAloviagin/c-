﻿Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2 && number1 > number3)
{
    Console.Write(number1);
}
else if(number2 > number1 && number2 > number3)
{
    Console.Write(number2);
}
else if(number3 > number1 && number3 > number2)
{
    Console.Write(number3);
}