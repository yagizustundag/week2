
using System.ComponentModel;

Console.WriteLine("Enter your last name:");
string LastName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):");

char UserGender = Char.Parse(Console.ReadLine());

string Greating;

if (UserGender == 'f')
{
    Greating = "Ms. ";
}
else if (UserGender == 'm')
{
    Greating = "Mr. ";
}
else
{
    Greating = "";
}

Console.WriteLine($"Hello, {Greating}{LastName}!");

Console.WriteLine("Enter your year of birth:");


int UserBirth = Int16.Parse(Console.ReadLine());
int CurrentYear = DateTime.Now.Year;
byte UserAge = Convert.ToByte(CurrentYear - UserBirth);

if (UserAge >= 13)
{
    Console.WriteLine($"AGE: {UserAge}. Accaunt can be registered");
}
else
{
    Console.WriteLine($"AGE: {UserAge}. Accaunt can't be registered: error age restriction 13+");
}