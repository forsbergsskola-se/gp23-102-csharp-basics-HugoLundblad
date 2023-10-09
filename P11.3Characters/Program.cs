// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine()!;
var c = input.ToUpper();
char index = char.Parse(c);
//char c = 'b'; you may use lower case character.

// bool vowel = input == "A" ? "B" :  ;

if (index >= 48 && index <= 57)
{
    Console.WriteLine("That's a number.");
}
else if (index >= 65 && index <= 90 || index >= 97 && index <= 122)
{
    Console.WriteLine(index == 65 || index == 69 || index == 73 || index == 79 || index == 85 || index == 89 ? "That's a vowel." : "That's a consonant. ");
}
else
{
    Console.WriteLine("Invalid Symbol.");
}

/*if (input )
{
    
}*/

Console.WriteLine("Hello, World!");
