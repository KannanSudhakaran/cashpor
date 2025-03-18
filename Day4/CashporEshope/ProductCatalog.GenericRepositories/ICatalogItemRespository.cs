using ProductCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.GenericRepositories
{
    public interface ICatalogItemRespository:IGenericRepository<CatalogItem>
    {
        //if you need any specifi methods
    }

    public interface ICatalogBrandRespository : IGenericRepository<CatalogBrand>
    {
        //if you need any specifi methods
    }

    public interface ICatalogType : IGenericRepository<CatalogType>
    {
        //if you need any specifi methods
    }
}
