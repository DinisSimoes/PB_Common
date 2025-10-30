namespace PB_Common.Events
{
    public record MovedToDlqEvent(Guid FailureId, string MessageType, string Reason, DateTime OccurredUtc);
}
