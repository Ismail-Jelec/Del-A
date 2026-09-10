string Mjölk = mjölk;
string Bröd = bröd;
string Ost = ost;
string Ajvar = Ajvar;

static void Buy()
{
    Console.ReadLine();

}



List <Store> items = [];


while(true)
{
    string[] menu = [
        "Vad vill du köpa?",
        "Mjölk - 15kr",
        "Bröd - 32kr", 
        "Ost - 89kr",
        "Ajvar - 30kr",
    ];

    string choice = Ask(string.Join("\n", menu) + "\n");
    if (choice = "1")
    {
        
    }

}