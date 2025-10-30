namespace PB_Common.Events
{
    public record CartaoCriadoEvent(Guid ClienteId, string NumeroCartao, decimal Limite, DateTime DataCriacao);
}
