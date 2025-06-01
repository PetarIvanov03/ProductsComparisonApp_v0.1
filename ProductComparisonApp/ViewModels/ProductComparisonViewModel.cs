using System.Collections.Generic;
using ProductComparisonApp.Models;

namespace ProductComparisonApp.ViewModels
{
    public class ProductComparisonViewModel<TProduct>
    {
        public string CategoryName { get; set; }
        public List<TProduct> Products { get; set; }
        public List<int> SelectedProductIds { get; set; }

        public ProductComparisonViewModel()
        {
            Products = new List<TProduct>();
            SelectedProductIds = new List<int>();
        }
    }
}
