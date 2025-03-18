using ProductCatalog.Domain;
using ProductCatalog.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObjects
{
    //Integration,email notication
    public class CatalogItemBO : ICatalogItemBO
    {
        private readonly ICatalogItemRespository _repository;
        private readonly ICatalogBrandRespository _catalogBrandRespository;


        public CatalogItemBO(ICatalogItemRespository catalogItemRespository)
        {
            _repository = catalogItemRespository;
        }

        public async Task<CatalogItem> Add(CatalogItem item)
        {
            await _repository.Add(item);
            return item;
        }
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
        public async Task<CatalogItem> GetCatalogItemDetails(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task<IEnumerable<CatalogItem>> GetCatalogItems()
        {
            return await _repository.GetAll();
        }
        public async Task Update(CatalogItem item)
        {
            await _repository.Update(item);
        }

    }
}
