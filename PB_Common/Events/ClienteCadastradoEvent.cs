namespace PB_Common.Events
{
    public record ClienteCadastradoEvent(Guid ClienteId, string Nome, string Cpf, DateTime DataCriacao);
}
