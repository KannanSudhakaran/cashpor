using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.API.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductCataglobDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCataglobDbContext") ?? throw new InvalidOperationException("Connection string 'ProductCataglobDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope= app.Services.CreateScope()) { 

    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ProductCataglobDbContext>();
    //context.Database.EnsureCreated();
    ProductCatalogSeed.SeedAsync(context).Wait();

}

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
