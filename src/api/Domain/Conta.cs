namespace dotnetBanking.Api.Domain;

public class Conta
{
    public int Id { get; private set; }
    public string Titular { get; private set; } 
    public decimal Saldo { get; private set; }

    public Conta(string titular, decimal saldoInicial = 0m)
    {
        //fazer validações
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Atualizar(string titular, decimal saldo)
    {
        //fazer validações
        Titular = titular;
        Saldo = saldo;
    }

    public bool Sacar(decimal valor)
    {
        Saldo = valor;
        return true;
    }

    public void Depositar(decimal valor)
    {
        //fazer validações
        Saldo += valor;
    }
}
