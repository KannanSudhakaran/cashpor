using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain;
using ProductCatalog.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepositories
{
    public class CatalogItemRepository : CatalogGenericReposiotry<CatalogItem>, ICatalogItemRespository
    {

        ProductCatalogDbContext _context;
        public CatalogItemRepository(ProductCatalogDbContext context) : base(context)
        {
            _context = context; 
        }

        public async override Task<CatalogItem> GetById(int id)
        {
            var catalogItem = await
            _context.CatalogItems
            .Include("CatalogType")
            .Include("CatalogBrand")
            .FirstAsync(item => item.Id == id);
            if (catalogItem == null)
            {
                throw new ApplicationException("Not Found");
            }
            return catalogItem;
        }
        public async override Task<IEnumerable<CatalogItem>> GetAll()
        {
            return await _context.CatalogItems
                .Include("CatalogType")
                .Include("CatalogBrand")
                .ToListAsync();
        }

     
    }
}
