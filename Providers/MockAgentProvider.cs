namespace ConsejoIA.Providers;

public class MockAgentProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        // Simulamos que la IA está "pensando" durante 2 segundos
        await Task.Delay(2000);

        // Devolvemos una respuesta falsa
        return $"[MOCK] Recibí tu pregunta: '{prompt}'. Esta es una respuesta simulada.";
    }
}
