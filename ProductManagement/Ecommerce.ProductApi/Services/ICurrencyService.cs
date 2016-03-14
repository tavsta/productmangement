using System.Collections.Generic;
using Ecommerce.ProductApi.Models;

namespace Ecommerce.ProductApi.Services
{
    public interface ICurrencyService
    {
        IEnumerable<CurrencyModel> Get();
        CurrencyModel Get(int id);
        void Create(CurrencyModel product);
        void Update(CurrencyModel product);
        void Delete(int id);
    }
}