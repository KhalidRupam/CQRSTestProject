using CQRSTest.DataAccessLayer;
using CQRSTest.DataAccessLayer.Queries;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.GetDAOServices();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly:Assembly.GetExecutingAssembly());
    config.RegisterServicesFromAssembly(typeof(GetPersonDetailQuery).Assembly);
});

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
