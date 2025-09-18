namespace api.Dtos;

public record CreateContaDto(string Titular, decimal SaldoInicial);
public record UpdateContaDto(string Titular, decimal Saldo);
public record ContaDto(int Id, string Titular, decimal Saldo);
