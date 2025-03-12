using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObjects;
using ProductCatalog.Domain;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogItemController : ControllerBase
    {

        private readonly ICatalogItemBO _catalogItemBO;
        public CatalogItemController(ICatalogItemBO catalogitemBo)
        {
            _catalogItemBO = catalogitemBo;
        }

        // GET: api/CatalogItems
        [HttpGet]
        public async Task<IActionResult> GetCatalogItems()
        {
            //DTO
            var items = await _catalogItemBO.GetCatalogItems();
            return Ok(items.ToList());
        }
    }
}
