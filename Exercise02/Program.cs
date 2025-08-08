// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Convert;

//Console.WriteLine("Hello, World!");




try
{
    checked
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
            //ReadLine();
        }
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}
