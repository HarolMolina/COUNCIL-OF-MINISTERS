namespace ConsejoIA.Providers;

public interface IAgentProvider
{
    Task<string> GetResponseAsync(string prompt);
}
