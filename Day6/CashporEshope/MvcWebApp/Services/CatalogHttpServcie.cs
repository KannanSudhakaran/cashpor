using MvcWebApp.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MvcWebApp.Services
{
   
    public class CatalogHttpServcie : ICatalogHttpServcie
    {

        private string _baseUrl;
        public CatalogHttpServcie(IConfiguration config)
        {
            _baseUrl = config["CatalogAPIBaseUrl"];
        }

        public async Task<CatalogItemDTO> GetCatalogItemDetails(int id)
        {
            var client = new HttpClient();

            var dataJsonString = await client.GetStringAsync(_baseUrl + "/api/v1/catalogitem/"+id);

            var response = JsonConvert.DeserializeObject<CatalogItemDTO>(dataJsonString);

            return  response;
        }

        public async Task<IEnumerable<CatalogItem>> GetCatalogItems()
        {

            var client = new HttpClient();

            var dataJsonString = await client.GetStringAsync(_baseUrl + "/api/v1/catalogitem");

            var response = JsonConvert.DeserializeObject<IEnumerable<CatalogItem>>(dataJsonString);

            return response;
        }

        public async Task Update(int id,CatalogItemDTO item)
        {
            var client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(item), System.Text.Encoding.UTF8,"application/json");

            var result = await client.PutAsync(_baseUrl + "/api/v1/CatalogItem/" + id, content);
        }
    }
}
