namespace Ecommerce.ProductApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;
    using Services;

    public class CurrenciesController : ApiController
    {
        private ICurrencyService _currencyService { get; set; }

        public IEnumerable<CurrencyModel> Get()
        {
            return _currencyService.Get();
        }

        public CurrencyModel Get(int id)
        {
            return _currencyService.Get(id);
        }

        [HttpPost]
        public void Create(CurrencyModel product)
        {
            _currencyService.Create(product);
        }

        [HttpPost]
        public void Update(CurrencyModel product)
        {
            _currencyService.Update(product);
        }

        public void Delete(int id)
        {
            _currencyService.Delete(id);
        }
    }
}