using MvcWebApp.Models;

namespace MvcWebApp.Services
{
    public interface ICatalogHttpServcie
    {
        Task<IEnumerable<CatalogItem>> GetCatalogItems();
        Task<CatalogItemDTO> GetCatalogItemDetails(int id);

        Task Update(int id, CatalogItemDTO item);
    }
}