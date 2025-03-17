using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;
using MvcWebApp.Services;
using System.Threading.Tasks;

namespace MvcWebApp.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogHttpServcie _catalogHttpServcie;

        public CatalogController(ICatalogHttpServcie catalogHttpServcie) {

            _catalogHttpServcie = catalogHttpServcie;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _catalogHttpServcie.GetCatalogItems();
            return View(items);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var item = await _catalogHttpServcie.GetCatalogItemDetails(id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,CatalogItemDTO item)
        {
            await _catalogHttpServcie.Update(id, item);
            return RedirectToAction("Index");
        }


    }
}
