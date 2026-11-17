using ConcessionariaAPI.Contexts;
using ConcessionariaAPI.Interfaces;
using ConcessionariaAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();


builder.Services.AddDbContext<ConcessionariaContext>(options =>
    // Diz que o banco é SQL Server e busca a connection string chamada "Concessionaria"
    // dentro da seção ConnectionStrings do appsettings.json.
    options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));


builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();


var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
