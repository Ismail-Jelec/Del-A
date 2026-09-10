/*
string Mjölk = mjölk;
string Bröd = bröd;
string Ost = ost;
string Ajvar = ajvar;
*/


List <string> items = new List<string>();
List <int> kr = new List<int>();

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

while(true)
{
    string[] menu = [
        "Välkommen till Gamestop!",
        "Vad vill du köpa?\n",
        "GTA 6 - 899kr",
        "F1 25 - 700kr", 
        "Minecraft - 239kr",
        "Elden Ring - 500kr",
        "LMU - 249kr"
    ];

    string choice = Ask(string.Join("\n", menu) + "\n");
    if (choice = "GTA 6")
    {
        string item = Console.ReadLine();
        items.Add(item);
    }

    else if (choice = "F1 25")
    {
        string item = Console.ReadLine();
        items.Add(item);
    }
    
    else if (choice = "Minecraft")
    {
        string item = Console.ReadLine();
        items.Add(item);
    }

    else if (choice = "Elden Ring")
    {
        string item = Console.ReadLine();
        items.Add(item);
    }

    else if (choice = "LMU")
    {
        string item = Console.ReadLine();
        items.Add(item);
    }

    else
    {
        Console.WriteLine("Spelet finns inte");
    }


}