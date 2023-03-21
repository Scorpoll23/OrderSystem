using IronHelmOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Models
{
    public class ClientModel : IClientModel
    {
        private int ClientID;

        private string Name;

        private string NumberOrName;

        private string AddressLine1;

        private string AddressLine2;

        private string Postcode;

        private string Country;

        public ClientModel()
        {

        }

        public ClientModel(string name,
                           string numberOrName,
                           string addressLine1,
                           string addressLine2,
                           string postcode,
                           string country)
        {
            this.Name = name;
            this.NumberOrName = numberOrName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.Postcode = postcode;
            this.Country = country;
        }

        public ClientModel(int clientID)
        {
            GetClientById(clientID);
        }

        public int GetClientID()
        {
            return ClientID;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetNumberOrName()
        {
            return NumberOrName;
        }

        public string GetAddressLine1()
        {
            return AddressLine1;
        }

        public string GetAddressLine2()
        {
            return AddressLine2;
        }

        public string GetPostcode()
        {
            return Postcode;
        }

        public string GetCountry()
        {
            return Country;
        }

        public void Save(string name,
                         string numberOrName,
                         string addressLine1,
                         string addressLine2,
                         string postcode,
                         string country)
        {
            this.Name = name;
            this.NumberOrName = numberOrName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.Postcode = postcode;
            this.Country = country;

            CreateOrUpdate();
        }

        public void CreateOrUpdate()
        {
            using (var ctx = new DatabaseEntities())
            {
                var client = FromModel();

                if (client.ClientID == 0)
                    ctx.Clients.Add(client);
                else
                    ctx.Entry(client).State = EntityState.Modified;

                ctx.SaveChanges();
            }
        }

        public void GetClientById(int clientID)
        {
            using (var ctx = new DatabaseEntities())
            {
                var client = ctx.Clients.SingleOrDefault(x => x.ClientID == clientID);

                if (client != null)
                    ToModel(client);
            }
        }

        private void ToModel(Client client)
        {
            ClientID = client.ClientID;
            Name = client.Name;
            NumberOrName = client.NumberOrName;
            AddressLine1 = client.AddressLine1;
            AddressLine2 = client.AddressLine2;
            Postcode = client.Postcode;
            Country = client.Country;
        }

        private Client FromModel()
        {
            return new Client
            {
                ClientID = ClientID,
                Name = Name,
                NumberOrName = NumberOrName,
                AddressLine1 = AddressLine1,
                AddressLine2 = AddressLine2,
                Postcode = Postcode,
                Country = Country
            };
        }
    }
}
