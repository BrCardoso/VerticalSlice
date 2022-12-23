using Application.Shared.Repository.MongoDB.DependencyInjection;
using Application.Features.CreateCustomer.DependencyInjection;
using Application.Shared.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabase(configuration);
builder.Services.AddCreateCustomer();
builder.Services.AddUpdateCustomer();
builder.Services.AddMediatRExtension();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
