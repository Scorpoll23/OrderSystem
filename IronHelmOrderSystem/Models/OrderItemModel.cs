using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Models
{
    public class OrderItemModel : IOrderItemModel
    {
        public int OrderItemID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public byte[] Artwork { get; set; }

        public int HoursRequired { get; set; }

        public float Price { get; set; }

        public OrderItemModel()
        {

        }
    }
}
