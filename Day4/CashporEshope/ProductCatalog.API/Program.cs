using Microsoft.EntityFrameworkCore;
using ProductCatalog.BusinessObjects;
using ProductCatalog.EFRepositories;
using ProductCatalog.GenericRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductCatalogDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCatalogContext") ?? throw new InvalidOperationException("Connection string 'ProductCatalogContext' not found.")));

builder.Services.AddScoped<ICatalogItemRespository, CatalogItemRepository>();
builder.Services.AddScoped<ICatalogItemBO, CatalogItemBO>();

var app = builder.Build();

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ProductCatalogDbContext>();

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
