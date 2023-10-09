// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input a whole number.");

int input = int.Parse(Console.ReadLine());

if (input % 2 == 0)   
{
    Console.WriteLine("That's even.");    
}
else
{
    Console.WriteLine("That's odd.");  
}