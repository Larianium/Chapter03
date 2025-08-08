﻿// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Convert;

//Console.WriteLine("Hello, World!");

//WriteLine("Before parsing");
//Write("What is your age? ");
//string? input = ReadLine(); // или используйте значение "49" в блокноте
//try
//{
//    int age = int.Parse(input);
//    WriteLine($"You are {age} years old.");
//}
//catch (OverflowException)
//{
//    WriteLine("Your age is a valid number format but it is either too big or small.");
//}
//catch (FormatException)
//{
//    WriteLine("The age you entered is not a valid number format.");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says {ex.Message}");
//}
//WriteLine("After parsing");


Write("Enter an amount: ");
string? amount = ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}
