// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using static System.Console;
using static System.Convert;

//try
//{
//    checked
//    {
//        Write("Enter a number between 0 and 255: ");
//        string? first = ReadLine();

//        Write("Enter another number between 0 and 255: ");
//        string? second = ReadLine();
//        int b = Convert.ToInt32(first) / Convert.ToInt32(second);

//        Write($"{first} divided by {second} is {b}");
//    }
//}
//catch (FormatException)
//{
//    WriteLine("The value must be numeric, not string.");
//}
//catch (DivideByZeroException)
//{
//    WriteLine("Division by zero is prohibited.");
//}

int x = 3;
int y = 2 + ++x;

Write($"{y}");




