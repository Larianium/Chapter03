// See https://aka.ms/new-console-template for more information
using static System.Console;

//Console.WriteLine("Hello, World!");

//int a = 3;
//int b = a++;
//WriteLine($"a is {a}, b is {b}");

//int c = 3;
//int d = ++c; // увеличение с перед присваиванием
//WriteLine($"c is {c}, d is {d}");

int e = 11;
int f = 3;
double g = 11.0;


WriteLine($"g / f = {g / f}");
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
WriteLine($"g is {g:N1}, f is {f}");

int p = 6;
p += 3; // эквивалентно p = p + 3;
p -= 3; // эквивалентно p = p – 3;
p *= 3; // эквивалентно p = p * 3;
p /= 3; // эквивалентно p = p / 3;