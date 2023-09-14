// See https://aka.ms/new-console-template for more information

//SpeedConverter

Console.WriteLine("Welcome to km/h to m/2 converter.");
Console.WriteLine("Please enter a value in km/h.");
string userInput = Console.ReadLine();
float userNumber = float.Parse(userInput);
float x = userNumber / 60 / 60 * 1000;

Console.WriteLine($"That would be {x} m/s.");