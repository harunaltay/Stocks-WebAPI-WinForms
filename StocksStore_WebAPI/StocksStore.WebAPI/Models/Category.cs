using System.Collections.Generic;
using Newtonsoft.Json;

namespace StocksStore.WebAPI.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // this is for to ignore this NAVIGATION PROPERTY!
        // This solved MY PROBLEM!
        // https://stackoverflow.com/questions/19467673/entity-framework-self-referencing-loop-detected
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}