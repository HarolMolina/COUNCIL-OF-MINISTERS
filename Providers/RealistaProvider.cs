namespace ConsejoIA.Providers;

public class RealistaProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);
        return $"[REALISTA] Ante la pregunta '{prompt}', es importante analizar ambos lados. Por un lado, existen beneficios potenciales como oportunidades de crecimiento. Por otro lado, hay riesgos que deben considerarse cuidadosamente. La decisión depende de tu situación específica, recursos disponibles y tolerancia al riesgo. Te recomiendo evaluar objetivamente los pros y contras antes de actuar.";
    }
}
