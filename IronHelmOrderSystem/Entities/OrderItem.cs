using System.ComponentModel.DataAnnotations;

namespace IronHelmOrderSystem.Entities
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public byte[] Artwork { get; set; }

        [Required]
        public int HoursRequired { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual Order Order { get; set; }

        public OrderItem()
        {

        }
    }
}