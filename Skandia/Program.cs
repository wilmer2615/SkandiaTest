using Logic.CreditCardLogic;
using Logic.FirstHundredNumbers;
using Logic.PrimeNumbers;
using Logic.SavingsAccountLogic;
using Logic.TextString;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Repository.CreditCardRepository;
using Repository.Repository.SavingsAccountRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Se realiza la configuracion de la inyección de dependencias.
builder.Services.AddScoped<ICreditCardRepository, CreditCardRepository>();
builder.Services.AddScoped<ISavingsAccountRepository, SavingsAccountRepository>();

builder.Services.AddScoped<IFirstHundredNumbersLogic, FirstHundredNumbersLogic>();
builder.Services.AddScoped<IPrimeNumbersLogic, PrimeNumbersLogic>();
builder.Services.AddScoped< ITextStringLogic, TextStringLogic>();
builder.Services.AddScoped<ICreditCardLogic, CreditCardLogic>();
builder.Services.AddScoped<ISavingAccountLogic, SavingAccountLogic>();

//Configuracion conexion a base de datos
builder.Services.AddDbContext<AplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

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
