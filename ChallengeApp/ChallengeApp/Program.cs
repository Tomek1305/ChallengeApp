string name = "Ewa";
var gender = "Kobieta";
int age = 18;

if(age < 30 && gender =="Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(gender == "Kobieta"  && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if(name == "Tomek" && age > 33)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Ta kobieta ma na imie Ewa");
}
