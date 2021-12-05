using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using catalog.API.Entities;

namespace catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
