using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Presenters
{
    public class ClientPresenter
    {
        private IClientUI clientUI;
        private IClientModel clientModel;

        public ClientPresenter(IClientModel clientModel, IClientUI clientUI)
        {
            this.clientModel = clientModel;
            this.clientUI = clientUI;

            clientUI.Register(this);

            SetupForm();
        }

        private void SetupForm()
        {
            if (clientModel.GetClientID() != 0)
            {
                clientUI.ClientName = clientModel.GetName();
                clientUI.NumberOrName = clientModel.GetNumberOrName();
                clientUI.AddressLine1 = clientModel.GetAddressLine1();
                clientUI.AddressLine2 = clientModel.GetAddressLine2();
                clientUI.Postcode = clientModel.GetPostcode();
                clientUI.Country = clientModel.GetCountry();
            }
        }

        public void SaveClient()
        {
            clientModel.Save(clientUI.ClientName,
                               clientUI.NumberOrName,
                               clientUI.AddressLine1,
                               clientUI.AddressLine2,
                               clientUI.Postcode,
                               clientUI.Country);
        }
    }
}
