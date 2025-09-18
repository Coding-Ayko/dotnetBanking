using api.Data;
using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnetBanking.Repositories;

public class ContaEfRepository : IContaRepository
{
    private readonly AppDbContext _ctx;
    public ContaEfRepository(AppDbContext ctx) => _ctx = ctx;

    public async Task<List<Conta>> ListarAsync(CancellationToken ct)
        => await _ctx.Contas.AsNoTracking().ToListAsync(ct);

    public async Task<Conta?> ObterAsync(int id, CancellationToken ct)
        => await _ctx.Contas.FindAsync(new object?[] { id }, ct);

    public async Task AdicionarAsync(Conta conta, CancellationToken ct)
    {
        await _ctx.Contas.AddAsync(conta, ct);
        await _ctx.SaveChangesAsync(ct);
    }

    public async Task AtualizarAsync(Conta conta, CancellationToken ct)
    {
        _ctx.Contas.Update(conta);
        await _ctx.SaveChangesAsync(ct);
    }

    public async Task RemoverAsync(Conta conta, CancellationToken ct)
    {
        _ctx.Contas.Remove(conta);
        await _ctx.SaveChangesAsync(ct);
    }
}
