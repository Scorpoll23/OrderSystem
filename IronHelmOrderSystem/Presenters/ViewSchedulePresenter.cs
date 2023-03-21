using IronHelmOrderSystem.Entities.Enum;
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
    public class ViewSchedulePresenter
    {
        IOrderModel orderModel;
        IViewScheduleUI viewScheduleUI;

        public ViewSchedulePresenter(IOrderModel orderModel, IViewScheduleUI viewScheduleUI)
        {
            this.orderModel = orderModel;
            this.viewScheduleUI = viewScheduleUI;

            viewScheduleUI.Register(this);

            Setup();
        }

        private void Setup()
        {
            SetScheduleList();
        }

        private void SetScheduleList()
        {
            // Get Order Schedules within 2 month range of this order.
            var orderSchedules = orderModel.GetScheduleRange(2);

            if (orderSchedules != null)
            {
                DataTable orderScheduleTable = new DataTable();
                orderScheduleTable.Columns.Add("Order ID", typeof(int));
                orderScheduleTable.Columns.Add("Order Name", typeof(string));
                orderScheduleTable.Columns.Add("Order Source", typeof(OrderSource));
                orderScheduleTable.Columns.Add("Progress", typeof(byte));
                orderScheduleTable.Columns.Add("Start Date", typeof(DateTime));
                orderScheduleTable.Columns.Add("End Date", typeof(DateTime));

                foreach (var orderSchedule in orderSchedules)
                    orderScheduleTable.LoadDataRow(new object[]
                    {
                        orderSchedule.Item1,
                        orderSchedule.Item2,
                        orderSchedule.Item3,
                        orderSchedule.Item4,
                        orderSchedule.Item5,
                        orderSchedule.Item6
                    }, false);

                viewScheduleUI.SetScheduleList(orderScheduleTable);
            }
        }

        public int GetOrderID()
        {
            return orderModel.OrderID;
        }
    }
}
