using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.API.Domain;

namespace ProductCatalog.API.Data
{
    public class ProductCataglobDbContext : DbContext
    {
        public ProductCataglobDbContext (DbContextOptions<ProductCataglobDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCatalog.API.Domain.CatalogType> CatalogTypes { get; set; } = default!;
        public DbSet<ProductCatalog.API.Domain.CatalogItem> CatalogItems { get; set; } = default!;
        public DbSet<ProductCatalog.API.Domain.CatalogBrand> CatalogBrands { get; set; } = default!;
    }
}
