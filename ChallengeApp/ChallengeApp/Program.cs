var name = "Ewa";
char sex = 'K';
var age = 28;

if (name == "Ewa" && age < 30)
{
    Console.WriteLine("Ewa mniej niz 30 lat");
}
else if (sex == 'K' && age == 30)
{
    Console.WriteLine("Kobieta lat 30");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni meszczyzna");
}
else
{
    Console.WriteLine("Nie pasuje do żadnych danych");
}

