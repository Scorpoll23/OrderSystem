using System;
using System.Collections.Generic;
using System.Data;
using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Views;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Util;
using IronHelmOrderSystem.Models;

namespace IronHelmOrderSystem.Presenters
{
    public class OrderListPresenter
    {
        private IOrderListUI orderListUI;
        private IRepository repository;

        public OrderListPresenter(IOrderListUI orderListUI, IRepository repository)
        {
            this.orderListUI = orderListUI;
            this.repository = repository;
        }

        public void SetClientList()
        {
            List<Client> clients = repository.GetAllClients();
            Dictionary<int, string> clientList = new Dictionary<int, string>();

            foreach (Client client in clients)
                clientList.Add(client.ClientID, client.Name);

            orderListUI.SetClientList(clientList);
        }

        public void UpdateOrderList(int clientID)
        {
            List<Order> selectedOrders = repository.GetOrdersByClientID(clientID);

            DataTable clientOrdersDataTable = new DataTable();
            clientOrdersDataTable.Columns.Add("Order ID", typeof(int));
            clientOrdersDataTable.Columns.Add("Order Name", typeof(string));
            clientOrdersDataTable.Columns.Add("Order Source", typeof(OrderSource));
            clientOrdersDataTable.Columns.Add("Order State", typeof(OrderState));
            clientOrdersDataTable.Columns.Add("Enquiry Date", typeof(DateTime));
            clientOrdersDataTable.Columns.Add("Order Date", typeof(DateTime));
            clientOrdersDataTable.Columns.Add("Deadline", typeof(DateTime));

            foreach(Order order in selectedOrders)
                clientOrdersDataTable.LoadDataRow(new object[]
                    {
                        order.OrderID,
                        order.Name,
                        order.Source,
                        order.State,
                        order.EnquiryDate,
                        order.OrderDate,
                        order.Deadline
                    }, false);

            orderListUI.SetOrderList(clientOrdersDataTable);
        }

        public void ShowEditOrder(int orderID)
        {
            OrderUI orderUI = new OrderUI();
            OrderModel orderModel = new OrderModel(orderID);
            OrderPresenter orderPresenter = new OrderPresenter(orderModel, orderUI);
            orderUI.Register(orderPresenter);
            orderUI.ShowDialog();
        }
    }
}
