namespace PB_Common.Events
{
    public record PropostaCreditoCriadaEvent(Guid ClienteId, int Score, int Limite1, int? Limite2);
}
