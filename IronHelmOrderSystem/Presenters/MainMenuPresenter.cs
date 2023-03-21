using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronHelmOrderSystem.Views;
using IronHelmOrderSystem.Util;
using IronHelmOrderSystem.Models;

namespace IronHelmOrderSystem.Presenters
{
    public class MainMenuPresenter
    {
        public MainMenuPresenter()
        {
        }

        public void ShowNewEnquiry()
        {
            OrderUI orderUI = new OrderUI();
            OrderModel orderModel = new OrderModel();
            OrderPresenter orderPresenter = new OrderPresenter(orderModel, orderUI);
            orderUI.Register(orderPresenter);
            orderUI.ShowDialog();
        }

        public void ShowOrderList()
        {
            OrderListUI orderSearchUI = new OrderListUI();
            Repository repository = new Repository();
            OrderListPresenter orderSearchPresenter = new OrderListPresenter(orderSearchUI, repository);
            orderSearchUI.Register(orderSearchPresenter);
            orderSearchUI.ShowDialog();
        }
    }
}
