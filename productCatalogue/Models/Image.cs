using System.ComponentModel.DataAnnotations.Schema;

namespace productCatalogue.Models
{
    public class Image
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public string ImagePath { get; set; }
        public bool IsPrimary { get; set; }
    }
}
