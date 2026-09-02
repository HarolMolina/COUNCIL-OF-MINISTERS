namespace ConsejoIA.Core;

using ConsejoIA.Providers;

public class ConsejoOrquestador
{
    private readonly List<IAgentProvider> _consejeros;
    
    public ConsejoOrquestador(List<IAgentProvider> consejeros)
    {
        _consejeros = consejeros;
    }