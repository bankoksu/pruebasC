using Practica1.Application;
using Practica1.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICalculadora,Calculadora>();
builder.Services.AddSingleton<ICientifica, Cientifica>();
builder.Services.AddSingleton<IResultadoDivision, ResultadoDivision>();
builder.Services.AddSingleton<IVideoClubOperaciones, VideoClubOperaciones>();

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
