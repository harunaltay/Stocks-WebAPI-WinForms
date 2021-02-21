using System.Collections.Generic;

namespace StocksStore.WinForms.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierWebPage { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}