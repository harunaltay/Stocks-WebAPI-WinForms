using System.Collections.Generic;
using Newtonsoft.Json;

namespace StocksStore.WebAPI.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierWebPage { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}