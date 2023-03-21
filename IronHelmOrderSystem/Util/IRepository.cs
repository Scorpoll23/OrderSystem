using IronHelmOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Util
{
    public interface IRepository
    {
        List<Client> GetAllClients();

        List<Order> GetOrdersByClientID(int clientID);
    }
}
