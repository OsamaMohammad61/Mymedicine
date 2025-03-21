namespace Mymedicine.Model
{
    public class cart
    {
        public int Id { get; set; }
        public int? user_id { get; set; } = 0;
        public double? totalAmount { get; set; } = 0;

        public ICollection<product> product { get; set; }
    }
    
    
}
