namespace ConsejoIA.Providers;

public class CreativoProvider : IAgentProvider
{
    public async Task<string> GetResponseAsync(string prompt)
    {
        await Task.Delay(2000);

        return $"[CREATIVO] Ante la pregunta '{prompt}', te propongo una perspectiva completamente diferente. ¿Y si en lugar de enfocarte en el problema principal, exploras alternativas no convencionales? Podrías combinar elementos de diferentes enfoques, buscar soluciones laterales, o incluso redefinir completamente la pregunta. La innovación surge cuando nos atrevemos a pensar fuera de los esquemas tradicionales.";
    }
}
