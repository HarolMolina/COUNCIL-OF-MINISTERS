using ConsejoIA.Providers;

Console.WriteLine();
Console.WriteLine("====================================");
Console.WriteLine("=       COUNCIL OF MINISTERS       =");
Console.WriteLine("====================================");
Console.WriteLine();
Console.WriteLine("Write down the decision you want to ask about. (or 'exit' for finish)");

IAgentProvider provider = new MockAgentProvider();

while (true)
{
    string userQuestion = Console.ReadLine() ?? "";
    if (userQuestion.ToLower() == "exit")
    {
        break;
    }
    Console.WriteLine("Pensando...");

    string answer = await provider.GetResponseAsync(userQuestion);

    Console.WriteLine($"\nanswer: {answer}");
}
