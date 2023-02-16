using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Dominio.Manipuladores;
using GitHubAccess.Infra.Mapeamento;
using GitHubAccess.Infra.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<GitHubManipulador>();
builder.Services.AddScoped<IGitHubServico, GitHubServico>();
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
