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
builder.Services.AddScoped<IAntecedentesRepository>(provider =>
{
    return new AntecedentesRepository(caminhoArquivoAntecedentes);
});

builder.Services.AddScoped<IEspeciesRepository>(provider =>
{
    return new EspeciesRepository(caminhoArquivoEspecies);
});



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
