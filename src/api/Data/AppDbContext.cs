using dotnetBanking.Api.Domain;
using Microsoft.EntityFrameworkCore;
namespace dotnetBanking.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) {}

    public DbSet<Conta> Contas => Set<Conta>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Conta>(e =>
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Titular).IsRequired().HasMaxLength(200);
            e.Property(c => c.Saldo).HasColumnType("decimal");
        });
    }
}
