namespace ConsejoIA.Providers;

// codigo para generar una respuesta automatica simulando una ia

public class MockAgentProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);

        return $"[MOCK] Recibí tu pregunta: '{prompt}'. Esta es una respuesta simulada.";
    }
}
