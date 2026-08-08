Console.WriteLine();
Console.WriteLine("====================================");
Console.WriteLine("=       COUNCIL OF MINISTERS       =");
Console.WriteLine("====================================");
Console.WriteLine();
Console.WriteLine("Write down the decision you want to ask about.");

string userQuestion = Console.ReadLine();

if (userQuestion == "")
{
    Console.WriteLine("no escribiste nada");
}
else
{
    int advisorsCount = 0;

    Console.WriteLine("pregunta valida");
    Console.WriteLine("select mode 1-quick 2-standard 3-deep.");
    string userMode = Console.ReadLine();
    switch (userMode)
    {
        case "1":
            userMode = "quick";
            advisorsCount = 2;
            break;
        case "2":
            userMode = "standard";
            advisorsCount = 3;
            break;
        case "3":
            userMode = "deep";
            advisorsCount = 5;
            break;
        default:
            Console.WriteLine("select valid input");
            return;
    }

    Console.WriteLine($"Tu Pregunta: {userQuestion}");
    Console.WriteLine($"Modo Selecionado: {userMode}");
    Console.WriteLine($"Se usarán {advisorsCount} consejeros.");

    string[] advisors = { "Red Team", "First Principles", "Expansionist", "Outsider", "Executor" };

    for (int i = 0; i < advisorsCount; i++)
    {
        Console.WriteLine(advisors[i]);
    }
}
