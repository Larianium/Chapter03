// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Convert;

//Console.WriteLine("Hello, World!");


//int a = 10;
//double b = a; // тип int можно безопасно привести к double
//WriteLine(b);

//double c = 9.8;
//int d = c; // компилятор выдаст ошибку на этой строке
//WriteLine(d);

//int d = (int)c;
//WriteLine(d); // d равняется 9 с потерей части .8


//long e = 5_000_000_000;
//int f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");
//e = long.MaxValue;
//f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");

//double g = 9.8;
//int h = ToInt32(g); // метод System.Convert
//WriteLine($"g is {g} and h is {h}");


//double[] doubles = new[]
// { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
//foreach (double n in doubles)
//{
//    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
//}

//foreach (double n in doubles)
//{
//    WriteLine(format:
//    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
//    arg0: n,
//    arg1: Math.Round(value: n, digits: 0,
//    mode: MidpointRounding.AwayFromZero));
//}

//int number = 12;
//bool boolean = true;
//object me = new();
//DateTime now = DateTime.Now;

//WriteLine(number.ToString());
//WriteLine(boolean.ToString());
//WriteLine(now.ToString());
//WriteLine(me.ToString());


//// выделение массива из 128 байт
//byte[] binaryObject = new byte[128];
//// заполнение массива случайными байтами
//(new Random()).NextBytes(binaryObject);
//WriteLine("Binary Object as bytes:");
//for (int index = 0; index < binaryObject.Length; index++)
//{
//    Write($"{binaryObject[index]:X} ");
//}
//WriteLine();
//// преобразование в строку Base64 и вывод в виде текста
//string encoded = ToBase64String(binaryObject);
//WriteLine($"Binary Object as Base64: {encoded}");

//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("4 July 1980");
//WriteLine($"I was born {age} years ago.");
//WriteLine($"My birthday is {birthday}.");
//WriteLine($"My birthday is {birthday:D}.");

//int count = int.Parse("abc");

Write("How many eggs are there? ");
string? input = ReadLine(); // или используйте "12" в блокноте
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}