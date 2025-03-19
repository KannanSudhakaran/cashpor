﻿using ProductCatalog.Domain;

namespace ProductCatalog.API.DTOs
{
    public class CatalogitemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureFileName { get; set; }
        public int CatalogTypeId { get; set; }
        public int CatalogBrandId { get; set; }
        public string CatalogBrand { get; set; }
        public string CatalogType { get; set; }
    }
}
