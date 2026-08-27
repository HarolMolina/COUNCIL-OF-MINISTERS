namespace ConsejoIA.Providers;

public class OptimistaProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);

        return $"[OPTIMISTA] Ante la pregunta '{prompt}', veo enormes oportunidades. Los beneficios superan ampliamente cualquier riesgo. ¡Esta es una gran ocasión para crecer y mejorar!";
    }
}
