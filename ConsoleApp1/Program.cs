// See https://aka.ms/new-console-template for more information

int hjälteHp = 100;
int monsterHp = 100;

string hjälteNamn = "HJÄLTE";
string monsterNamn = "MONSTER";

Random generator = new Random();

while (hjälteHp > 0 && monsterHp > 0)
{
    Console.WriteLine("Ny Runda");
    Console.WriteLine($"{hjälteNamn}: {hjälteHp}  {monsterNamn}: {monsterHp}\n");

    int hjälteSkada = Random.Shared.Next(50);
    monsterHp -= hjälteSkada;
    monsterHp = Math.Max(0, monsterHp);
    Console.WriteLine($"{hjälteNamn} gör {hjälteSkada} skada på {monsterNamn}");

    int monsterSkada = generator.Next(45);
    hjälteHp -= monsterSkada;
    hjälteHp = Math.Max(0, hjälteHp);
    Console.WriteLine($"{monsterNamn} gör {monsterSkada} skada på {hjälteNamn}");

    Console.WriteLine("Tryck på vilken knapp som helst för att fortsätta.");
    Console.ReadKey();
}

Console.WriteLine("Striden är klart");

if (hjälteHp == 0 && monsterHp == 0)
{
    Console.WriteLine("Oavgjort");
}
else if (hjälteHp == 0)
{
    Console.WriteLine($"{monsterNamn} vann!");
}
else
{
    Console.WriteLine($"{hjälteNamn} vann!");
}

Console.WriteLine("Tryck på vilken knapp som helst för att avsluta.");
Console.ReadKey();
