Random generator = new Random();

int p1Hp = 100;
int p2Hp = 100;


Console.WriteLine("Välkommen till Fight Club!");
Console.WriteLine("Vad är ditt namn.");
string fighter1 = Console.ReadLine();

string fighter2 = $"Onda {fighter1}";



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
    Console.WriteLine("OAVGJORT");
}
else if (p1Hp == 0)
{
    Console.WriteLine($"{fighter2} vann!");
}
else
{
    Console.WriteLine($"{fighter1} vann!");
}



Console.ReadKey();
