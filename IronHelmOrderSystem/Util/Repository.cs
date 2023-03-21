using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Entities.Enum;
using System.Data.Entity;

namespace IronHelmOrderSystem.Util
{
    public class Repository : IRepository
    {
        public Repository()
        {
        }

        public List<Client> GetAllClients()
        {
            using (var ctx = new DatabaseEntities())
                return ctx.Clients.ToList();
        }
        
        public List<Order> GetOrdersByClientID(int clientID)
        {
            using (var ctx = new DatabaseEntities())
            {
                return (from order in ctx.Orders
                        join client in ctx.Clients on order.Client.Name equals client.Name
                        where order.Client.ClientID == clientID
                        select order).ToList();
            }
        }
    }
}
