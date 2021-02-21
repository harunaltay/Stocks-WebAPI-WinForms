using System;
using Newtonsoft.Json;

namespace StocksStore.WebAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }
        [JsonIgnore]
        public virtual Supplier Supplier { get; set; }

        //TODO bu ilk TODO'm!!! Hayırlı olsun!

    }
}