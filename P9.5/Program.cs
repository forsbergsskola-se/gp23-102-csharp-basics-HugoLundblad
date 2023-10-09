// See https://aka.ms/new-console-template for more information

//CircleArea
Console.WriteLine("Circle Radius:");

string input = Console.ReadLine()!;
float num = float.Parse(input);

var result = num * num * Math.PI;

Console.WriteLine($"Circle Area: {result}");