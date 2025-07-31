// See https://aka.ms/new-console-template for more information
using static System.Console;

//Console.WriteLine("Hello, World!");


//int a = 10;
//double b = a; // тип int можно безопасно привести к double
//WriteLine(b);

//double c = 9.8;
//int d = c; // компилятор выдаст ошибку на этой строке
//WriteLine(d);

//int d = (int)c;
//WriteLine(d); // d равняется 9 с потерей части .8


long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");