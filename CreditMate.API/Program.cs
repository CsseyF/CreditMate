using CreditMate.Application;
using CreditMate.Persistence.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CreditMateContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CreditMateConnection"),
    b => b.MigrationsAssembly("CreditMate.Persistence")));

Builder.RepositoryBuilder(builder.Services);
Builder.ServiceBuilder(builder.Services);

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
