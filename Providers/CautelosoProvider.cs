namespace ConsejoIA.Providers;

public class CautelosoProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);
        return $"[CAUTELOSO] Ante la pregunta '{prompt}', si decides proceder, es fundamental que tengas un plan de contingencia. Identifica los 3 peores escenarios posibles y prepara una respuesta para cada uno. Asegúrate de tener redes de seguridad, recursos de respaldo y señales de alerta temprana. No se trata de evitar la acción, sino de actuar con preparación y tener un plan B sólido por si las cosas no salen como esperas.";
    }
}
