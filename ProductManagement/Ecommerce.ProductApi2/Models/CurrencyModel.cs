namespace Ecommerce.ProductApi.Models
{
    public class CurrencyModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public bool Default { get; set; }
    }
}