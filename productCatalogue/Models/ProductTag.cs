namespace productCatalogue.Models
{
    public class ProductTag
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int TagID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
