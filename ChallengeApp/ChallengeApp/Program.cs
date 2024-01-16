string name = "Ewa";
char sex = 'K';
int age = 17;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex != 'K' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
