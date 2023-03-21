using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IronHelmOrderSystem.Entities.Enum;

namespace IronHelmOrderSystem.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public OrderSource Source { get; set; }

        [Required]
        public OrderState State { get; set; }

        [Required]
        public DateTime EnquiryDate { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        public DateTime OrderDate { get; set; }

        public byte Progress { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
