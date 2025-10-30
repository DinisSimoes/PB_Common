namespace PB_Common.Events
{
    public record PropostaFalhaEvent(
        Guid FailureId,
        Guid ClienteId,
        string MessageType,
        string PayloadJson,
        int Attempt,
        string Reason,
        DateTime OccurredUtc
    );
}
