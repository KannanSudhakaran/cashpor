using ProductCatalog.Domain;

namespace ProductCatalog.BusinessObjects
{
    public interface ICatalogItemBO
    {
        Task<CatalogItem> Add(CatalogItem item);
        Task Delete(int id);
        Task<CatalogItem> GetCatalogItemDetails(int id);
        Task<IEnumerable<CatalogItem>> GetCatalogItems();
        Task Update(CatalogItem item);
    }
}