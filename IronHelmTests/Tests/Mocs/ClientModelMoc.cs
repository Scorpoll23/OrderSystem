using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Models;

namespace IronHelmTests.Tests.Mocs
{
    class ClientModelMoc : IClientModel
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public string NumberOrName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public ClientModelMoc()
        {
            ClientID = 1;
            Name = "Tim";
            NumberOrName = "NumberOrName";
            AddressLine1 = "1 Street Rd";
            AddressLine2 = "House Palace";
            Postcode = "NE12345";
            Country = "UK";
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

        public int GetClientID()
        {
            return this.ClientID; 
        }

        public string GetName()
        {
            return this.Name; 
        }

        public string GetNumberOrName()
        {
            return this.NumberOrName; 
        }

        public string GetAddressLine1()
        {
            return this.AddressLine1;
        }

        public string GetAddressLine2()
        {
            return this.AddressLine2;
        }

        public string GetPostcode()
        {
            return this.Postcode; 
        }

        public string GetCountry()
        {
            return this.Country; 
        }

        public void SetName(string name)
        {
            this.Name = name; 
        }
    }
}
