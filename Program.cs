using ConsejoIA.Providers;

const string programExit = "exit";

Console.WriteLine();
Console.WriteLine("====================================");
Console.WriteLine("=       COUNCIL OF MINISTERS       =");
Console.WriteLine("====================================");

IAgentProvider provider = new MockAgentProvider();

while (true)
{
    Console.WriteLine("Write down the decision you want to ask about. (or 'exit' for finish)");

    string userQuestion = Console.ReadLine() ?? "";
    if (userQuestion.ToLower() == programExit)
    {
        break;
    }
    Console.WriteLine("Pensando...");

    string answer = await provider.GetResponseAsync(userQuestion);

    Console.WriteLine($"\nanswer: {answer}");
}
