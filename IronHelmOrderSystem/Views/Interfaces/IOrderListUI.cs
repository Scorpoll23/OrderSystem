using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IronHelmOrderSystem.Presenters;

namespace IronHelmOrderSystem.Views
{
    public interface IOrderListUI
    {
        void Register(OrderListPresenter presenter);

        void SetClientList(Dictionary<int, string> source);

        void SetOrderList(DataTable dataTable);
    }
}
