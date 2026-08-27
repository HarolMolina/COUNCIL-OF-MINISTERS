namespace ConsejoIA.Providers;

public class PesimistaProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);

        return $"[OPTIMISTA] Ante la pregunta '{prompt}', veo enormes peligros. ";
    }
}
