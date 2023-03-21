using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Entities
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string NumberOrName { get; set; }

        [Required, MaxLength(100)]
        public string AddressLine1 { get; set; }

        [MaxLength(100)]
        public string AddressLine2 { get; set; }

        [Required, MaxLength(8)]
        public string Postcode { get; set; }

        [Required, MaxLength(100)]
        public string Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Client()
        {
            Orders = new List<Order>();
        }
    }
}
