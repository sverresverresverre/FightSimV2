Random generator = new Random();
bool game = true;

string restart;

while (game)
{

int p1Hp = 100;
int p2Hp = 100;


Console.WriteLine("Välkommen till Fight Club!");
Console.WriteLine("Vad är ditt namn.");
string fighter1 = Console.ReadLine();

string fighter2;

int p2Name = generator.Next(4);

if (p2Name == 1)
{
    fighter2 = "Micke B";
}
else if (p2Name == 2)
{
    fighter2 = "Kung Calle";
}
else
{
    fighter2 = "Piiz Kiz";
}



while (p1Hp > 0 && p2Hp > 0)
{
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
    Console.WriteLine($"{fighter1}: {p1Hp}  {fighter2}: {p2Hp}\n");
    Console.WriteLine("Tryck på valfri knapp för att starta rundan.");

    Console.ReadKey();

    int p1Damage = generator.Next(20);
    p2Hp -= p1Damage;
    p2Hp = Math.Max(0, p2Hp);
    Console.WriteLine($"\n{fighter1} gör {p1Damage} skada på {fighter2}");

    int p2Damage = generator.Next(20);
    p1Hp -= p2Damage;
    p1Hp = Math.Max(0, p1Hp);
    Console.WriteLine($"{fighter2} gör {p2Damage} skada på {fighter1}");

    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
}

if (p1Hp == 0 && p2Hp == 0)
{
    Console.WriteLine("\nOAVGJORT");
}
else if (p1Hp == 0)
{
    Console.WriteLine($"\n{fighter2} vann!");
}
else
{
    Console.WriteLine($"\n{fighter1} vann!");
}

Console.WriteLine("Play again?\ny/n\n");

restart = Console.ReadLine();

if (restart == "y")
{
    continue;
}
else
{
    break;
}


}