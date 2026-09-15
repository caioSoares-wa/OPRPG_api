using Application.UseCases;
using Domain.Interfaces;
using Infra.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

string caminhoArquivoAntecedentes = builder.Configuration["CaminhoArquivos:Antecedentes"];
string caminhoArquivoEspecies = builder.Configuration["CaminhoArquivos:Especies"];

//Container De Dependency Injection
builder.Services.AddScoped<IAntecedentesCatalog>(provider =>
{
    return new JsonAntecedentesCatalog(caminhoArquivoAntecedentes);
});

builder.Services.AddScoped<IEspeciesCatalog>(provider =>
{
    return new JsonEspeciesCatalog(caminhoArquivoEspecies);
});


builder.Services.AddScoped<IFichaRepository, FichaRepository>();
builder.Services.AddScoped<FichaUseCase>();
builder.Services.AddScoped<ObterTodasAsEspeciesUseCase>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
   

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
