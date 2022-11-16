// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using OperatorOverloading;

Fraction f1 = new Fraction(1, 2);
Fraction f2 = new Fraction(3, 4);

Console.WriteLine(f1 + f2);

Fraction f3 = new Fraction(5, 6);
Fraction f4 = new Fraction(1, 4);

Console.WriteLine(f3 + f4);

var b = f3 == f4;