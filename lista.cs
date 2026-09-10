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
        "Vad vill du köpa?",
        "Mjölk - 15kr",
        "Bröd - 32kr", 
        "Ost - 89kr",
        "Ajvar - 30kr",
    ];

    string choice = Ask(string.Join("\n", menu) + "\n");
    if (choice = "mjölk")
    {
        string item = new(Ask("Hur många mjölk paket vill du ha? "));
        items.Add(item);
    }

}