using Eventift.Application.Abstractions.Services;
using Eventift.Application.Abstractions.Services.Concrete;
using Eventify.Persistence.Services;
using Eventify.Persistence;
using Eventift.Application;
using Eventify.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IEventService, EventService>();
//builder.Services.AddScoped<ExportService>();
builder.Services.AddPersistenceService();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();


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
