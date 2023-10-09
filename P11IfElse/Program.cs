// See https://aka.ms/new-console-template for more information

using System.Numerics;

Console.WriteLine("What's your age?");
string input1 = Console.ReadLine()!;
int age = int.Parse(input1);

if (age <= 12)
{
    Console.WriteLine("You are a child.");

}
else if (age <= 19)
{
    Console.WriteLine("You are a teenager.");
} 
else {
    Console.WriteLine("You are a grown-up.");
}

Console.WriteLine("Give me another integer.");

string input2 = Console.ReadLine()!;
int num = int.Parse(input2);

int max = num > age ? num : age;
Console.WriteLine($"The maximum is {max}.");
if (max % 2 == 0)
{
    Console.WriteLine("It's an even number.");
}
else
{ 
    Console.WriteLine("It's an odd number.");
}