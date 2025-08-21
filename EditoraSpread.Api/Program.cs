using EditoraSpread.Application.Mapper;
using EditoraSpread.Application.Services;
using EditoraSpread.Domain.Interfaces;
using EditoraSpread.Infrastructure.Context;
using EditoraSpread.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona AutoMapper escaneando o assembly do MappingProfile
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Repositórios
builder.Services.AddScoped<IAutorRepository, AutorRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();

// Services
builder.Services.AddScoped<AutorService>();
builder.Services.AddScoped<LivroService>();
builder.Services.AddScoped<GeneroService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Pega a string de conexão do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Registra o DbContext para injeção de dependência
builder.Services.AddDbContext<EditoraContext>(options =>
    options.UseSqlServer(connectionString));

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
