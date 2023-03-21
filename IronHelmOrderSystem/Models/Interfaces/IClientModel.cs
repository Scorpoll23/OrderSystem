using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Models
{
    public interface IClientModel
    {
        int GetClientID();

        string GetName();

        string GetNumberOrName();

        string GetAddressLine1();

        string GetAddressLine2();

        string GetPostcode();

        string GetCountry();

        void GetClientById(int clientID);

        void Save(string name, string numberOrName, string addressLine1, string addressLine2, string postcode, string country);
    }
}
