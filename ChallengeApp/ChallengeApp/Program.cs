var name = "Ewa";
var sex = "K";
var age = 30;

if (age < 30 && sex == "K")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex == "M")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
