// See https://aka.ms/new-console-template for more information

Console.WriteLine("How many dollars do you want?");

int userInput = int.Parse(Console.ReadLine());

Console.WriteLine($"Here's your Dollars: {new string ('|', userInput)}");