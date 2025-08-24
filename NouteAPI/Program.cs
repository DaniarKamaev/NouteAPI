using MediatR;
using NouteAPI.Models.NouteDbContext;
using NouteAPI.Features.Get;
using NouteAPI.Features.Create;
using NouteAPI.Features.Edit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<NouteDbContext>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.MapCreateNouteEndPoint();
app.MapGetNoute();
app.MapEditNoute();

app.Run();
