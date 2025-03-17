using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using ProductCatalog.API.DTOs;
using ProductCatalog.BusinessObjects;
using ProductCatalog.Domain;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{
    [Route("api/v1/[controller]")]
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

            var itemDtos = ConvertToCatalogItemDto(items);

            return Ok(itemDtos);
        }

        private IEnumerable<CatalogitemDTO> ConvertToCatalogItemDto(IEnumerable<CatalogItem> items)
        {
            List<CatalogitemDTO> itemDtos = new List<CatalogitemDTO>();
            foreach (var item in items)
            {
                itemDtos.Add(new CatalogitemDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    PictureFileName = item.PictureFileName,
                    CatalogBrandId = item.CatalogBrandId,
                    CatalogTypeId = item.CatalogTypeId,
                    CatalogBrand = item.CatalogBrand.Brand,
                    CatalogType = item.CatalogType.Type
                });
            }

            return itemDtos;
        }

        [HttpPost]
        public async Task<ActionResult> PostCatalogItem(CatalogItem item) {

            var newItem=await _catalogItemBO.Add(item);
            return Ok(newItem.Id);


        }

        [HttpPut("{catalogItemId}")]
        public async Task<ActionResult> PutCatalogItem(int catalogItemId, CatalogItem item)
        {
            if (catalogItemId != item.Id)
            {
                return BadRequest();
            }
            await _catalogItemBO.Update(item);
            return NoContent();
        }

        [HttpGet("{catalogItemId}")]
        public async Task<ActionResult<CatalogItem>> GetCatalogItem(int catalogItemId)
        {
            var item = await _catalogItemBO.GetCatalogItemDetails(catalogItemId);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
