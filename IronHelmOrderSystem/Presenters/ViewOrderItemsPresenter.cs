using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Presenters
{
    public class ViewOrderItemsPresenter
    {
        IOrderModel orderModel;
        IViewOrderItemsUI viewOrderItemsUI;

        public ViewOrderItemsPresenter(IOrderModel orderModel, IViewOrderItemsUI viewOrderItemsUI)
        {
            this.orderModel = orderModel;
            this.viewOrderItemsUI = viewOrderItemsUI;

            viewOrderItemsUI.Register(this);

            Setup();
        }

        private void Setup()
        {
            SetOrderItemsList();
        }

        private void SetOrderItemsList()
        {
            var orderItems = orderModel.GetOrderItems();

            DataTable orderItemsDataTable = new DataTable();
            orderItemsDataTable.Columns.Add("Name", typeof(string));
            orderItemsDataTable.Columns.Add("Description", typeof(string));
            orderItemsDataTable.Columns.Add("Quantity", typeof(int));
            orderItemsDataTable.Columns.Add("Hours Required", typeof(int));
            orderItemsDataTable.Columns.Add("Price", typeof(float));

            foreach (var orderItem in orderItems)
                orderItemsDataTable.LoadDataRow(new object[]
                {
                    orderItem.Name,
                    orderItem.Description,
                    orderItem.Quantity,
                    orderItem.HoursRequired,
                    orderItem.Price
                }, false);

            viewOrderItemsUI.SetOrderItemsList(orderItemsDataTable);
        }
    }
}
