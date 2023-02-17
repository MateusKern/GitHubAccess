using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Dominio.Manipuladores;
using GitHubAccess.Infra.Contexto;
using GitHubAccess.Infra.Mapeamento;
using GitHubAccess.Infra.Servicos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<BdContexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"), m => m.MigrationsAssembly("GitHubAccess.Infra"));
    options.EnableSensitiveDataLogging();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<GitHubManipulador>();
builder.Services.AddScoped<IGitHubServico, GitHubServico>();
builder.Services.AddScoped<IGitHubRepositorio, GitHubAccess.Infra.Repositorios.GitHubRepositorio>();
builder.Services.AddAutoMapper(typeof(Mapeamento).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
