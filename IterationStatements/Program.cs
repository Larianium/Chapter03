// See https://aka.ms/new-console-template for more information
using static System.Console;

//Console.WriteLine("Hello, World!");


//int x = 0;
//while (x < 10)
//{
//    WriteLine(x);
//    x++;
//}

//int i = 0;
//string? password;
//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//    i++;
//}
//while (password != "Pa$$w0rd" && i < 10);

//if(i == 10)
//    WriteLine("The number of attempts is more than 10");

//if(password == "Pa$$w0rd")
//    WriteLine("Correct!");


//for (int y = 1; y <= 10; y++)
//{
//    WriteLine(y);
//}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
