using IronHelmOrderSystem.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Views
{
    public interface IClientListUI
    {
        void Register(ClientListPresenter presenter);

        void SetClientList(DataTable clientList);
    }
}
