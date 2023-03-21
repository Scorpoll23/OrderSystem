using IronHelmOrderSystem.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Views
{
    public interface IViewOrderItemsUI
    {
        void Register(ViewOrderItemsPresenter presenter);

        void SetOrderItemsList(DataTable orderItemsList);
    }
}
