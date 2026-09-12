using System.Linq;

List <string> items = new List<string>();
List <int> kr = new List<int>();

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

while(true)
{
    Console.WriteLine("\nVälkommen till Gamestop!");

    string[] menu = [
        "",
        "Vad vill du göra?",
        "Välj ett nummet\n",
        "1: Visa min varukorg",
        "2: Köpa ett spel",
        "3: Gå ut från butiken"
    ];

    string number = Ask(string.Join("\n", menu) + "\n" + "\nVad vill du göra? ");
    Console.Clear();

    if (number == "1")
    {
        for (int i = 0; i < items.Count; i++)
        Console.WriteLine($"{i + 1}. {items[i]} - {kr[i]}kr");

        int total = kr.Sum();
        Console.WriteLine($"Total: {total} kr");
        Console.WriteLine("__________________");

    }

    else if (number == "2")
    {
            string[] spel = [
            "",
            "Detta är våra spel",
            "",
            "GTA 6 - 899kr",
            "F1 25 - 700kr", 
            "Minecraft - 239kr",
            "Elden Ring - 500kr",
            "LMU - 249kr",
            "",
        ];

        string choice = Ask(string.Join("\n", spel) + "\nVad vill du köpa?");

        if (choice == "GTA 6")
        {
            items.Add(choice);
            kr.Add(899);
            Console.WriteLine("\nSpelet har lagts till i varukorgen");
            Console.WriteLine("____________________________________");
        }

        else if (choice == "F1 25")
        {
            items.Add(choice);
            kr.Add(700);
            Console.WriteLine("\nSpelet har lagts till i varukorgen");
            Console.WriteLine("____________________________________");
        }
        
        else if (choice == "Minecraft")
        {
            items.Add(choice);
            kr.Add(239);
            Console.WriteLine("\nSpelet har lagts till i varukorgen");
            Console.WriteLine("____________________________________");
        }

        else if (choice == "Elden Ring")
        {
            items.Add(choice);
            kr.Add(500);
            Console.WriteLine("\nSpelet har lagts till i varukorgen");
            Console.WriteLine("____________________________________");
        }

        else if (choice == "LMU")
        {
            items.Add(choice);
            kr.Add(249);
            Console.WriteLine("\nSpelet har lagts till i varukorgen");
            Console.WriteLine("____________________________________");
        }

        else
        {
            Console.WriteLine("Spelet finns inte");
            Console.WriteLine("_________________");
        }
    }

    else if (number == "3")
    {
        break;
    }

    else
    {
        Console.WriteLine("Numret är felaktigt");

    }

    


}