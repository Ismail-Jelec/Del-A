List <string> items = new List<string>();
List <int> kr = new List<int>();

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

while(true)
{
    Console.WriteLine("Välkommen till Gamestop!");

    string[] menu = [
        "",
        "Vad vill du göra?",
        "Välj ett nummet\n",
        "1: Visa min varukorg",
        "2: Köpa ett spel",
    ];

    string number = Ask(string.Join("\n", menu) + "\n");

    if (number == "1")
    {
        for (int i = 0; i < 0; i++);
        Console.WriteLine($"{i + 1}. {items[i]} - {kr[i]}");

        int total = kr.Sum();
        Console.WriteLine($"Total: {total} kr");
    }

    else if (number == "2")
    {
        
    }

    else
    {
        Console.WriteLine("Numret är felaktigt");

    }

    string[] spel = [
        "",
        "Detta är våra spel",
        "Skriv spelet som du vill lägga till i varukorgen\n",
        "GTA 6 - 899kr",
        "F1 25 - 700kr", 
        "Minecraft - 239kr",
        "Elden Ring - 500kr",
        "LMU - 249kr",
        "\nVad vill du köpa?",
        Console.ReadLine(),
    ];

    
    string choice = Ask(string.Join("\n", spel) + "\n");
    Console.Clear();

    if (choice == "GTA 6")
    {
        items.Add(choice);
        Console.WriteLine("Spelet har lagts till i varukorgen");
    }

    else if (choice == "F1 25")
    {
        items.Add(choice);
        Console.WriteLine("Spelet har lagts till i varukorgen");
    }
    
    else if (choice == "Minecraft")
    {
        items.Add(choice);
        Console.WriteLine("Spelet har lagts till i varukorgen");
    }

    else if (choice == "Elden Ring")
    {
        items.Add(choice);
        Console.WriteLine("Spelet har lagts till i varukorgen");
    }

    else if (choice == "LMU")
    {
        items.Add(choice);
        Console.WriteLine("Spelet har lagts till i varukorgen");
    }

    else
    {
        Console.WriteLine("Spelet finns inte");
    }


}