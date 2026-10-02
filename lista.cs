using System.Linq;

List <string> items = new List<string>();
List <int> kr = new List<int>();

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

    Console.WriteLine("");

    items.Add("Elden Ring"); kr.Add(499);
    items.Add("Minecraft"); kr.Add(239);
    items.Add("LMU"); kr.Add(200);



while (true)
{
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine($"{i+1}. {items[i]} - {kr[i]} kr");
    }
    
    Console.WriteLine($"Totalt: {kr.Sum()} kr");

    string input = Ask("\nSkriv ett spel du vill lägga till \neller skriv en siffra för ett spel du vill ta bort: ");
    

    if (int.TryParse(input, out int number))
    {
        if (number >= 1 && number <= items.Count)
        {
            items.RemoveAt(number - 1); kr.RemoveAt(number - 1);
        }
        else
        {
            Console.WriteLine("\nNumret finns inte\n");
        }
    }
    else
    {
        string priceInput = Ask("Vad kostar spelet\n");
    
        if (int.TryParse(priceInput, out int price))
        {
            items.Add(input);
            kr.Add(price);
        }
        else
        {
            Console.WriteLine("\nPriset är fel, spelet kunde inte läggas till\n");
        }
    }
}