using dotnetBanking.Data;
using dotnetBanking.Repositories;
using dotnetBanking.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers & Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext (SQLite)
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite("Data Source=bank.db"));

// DI - Services & Repositories
builder.Services.AddScoped<IContaRepository, ContaEfRepository>();
builder.Services.AddScoped<IContaService, ContaService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
