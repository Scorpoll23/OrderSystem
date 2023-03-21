using IronHelmOrderSystem.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Views
{
    public interface IClientUI
    {
        string ClientName { get; set; }

        string NumberOrName { get; set; }

        string AddressLine1 { get; set; }

        string AddressLine2 { get; set; }

        string Postcode { get; set; }

        string Country { get; set; }

        void Register(ClientPresenter presenter);
    }
}
