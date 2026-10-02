using System.Linq;

List <string> items = new List<string>();
List <int> kr = new List<int>();

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

    items.Add("Elden Ring"); kr.Add(499);
    items.Add("Minecraft"); kr.Add(239);
    items.Add("LMU"); kr.Add(200);



while (true)
{
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine($"{i+1} {items[i]} - {kr[i]} kr");
    }
    
    Console.WriteLine($"Totalt: {kr.Sum()} kr");

}