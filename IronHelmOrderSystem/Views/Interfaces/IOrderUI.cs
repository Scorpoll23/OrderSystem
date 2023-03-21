using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronHelmOrderSystem.Presenters;

namespace IronHelmOrderSystem.Views
{
    public interface IOrderUI
    {
        string Name { get; set; }

        void Register(OrderPresenter presenter);
    }
}
