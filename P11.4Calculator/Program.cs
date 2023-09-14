// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Input first a number, then an operator, then another number.");

int x = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

// var OpInput = Convert.ToChar(op);

if (op == '+')
{
    Console.WriteLine(x + y);
}
else if (op == '-')
{
    Console.WriteLine(x - y);
}
else if (op == '*')
{
    Console.WriteLine(x * y);
}
else if (op == '/')
{
    Console.WriteLine(x / y);
}
else if (op == '%')
{
    Console.WriteLine(x % y);
}
else 
{
    Console.WriteLine("Operator not found");
}