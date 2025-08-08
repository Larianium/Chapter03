// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Convert;

//Console.WriteLine("Hello, World!");

try
{
    checked
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 15 == 0)
            {
                WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                WriteLine("buzz");
            }
            else 
            {
                WriteLine(i);
            }
        }
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}
