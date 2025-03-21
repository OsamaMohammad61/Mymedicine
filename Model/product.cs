using Microsoft.AspNetCore.Authentication;

namespace Mymedicine.Model
{
    public class product
    {
        public int ProductId { get; set; }
        public string? name { get; set; } = "";
        public string? Description { get; set; } = "";
        public string? category { get; set; } = "";
        public string? brand { get; set; } = "";
        public double? price { get; set; } = 0.0;
        public int? quantity { get; set; } = 0;
        public bool? availibility { get; set; }=true;


        public ICollection<cart> cart { get; set; }
    }
}
