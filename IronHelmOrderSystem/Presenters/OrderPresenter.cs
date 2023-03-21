using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Views;
using System;

namespace IronHelmOrderSystem.Presenters
{
    public class OrderPresenter
    {
        IOrderModel orderModel;
        IOrderUI orderUI;

        public OrderPresenter(IOrderModel orderModel, IOrderUI orderUI)
        {
            this.orderModel = orderModel;
            this.orderUI = orderUI;

            orderUI.Register(this);
            SetUpForm();
        }

        private void SetUpForm()
        {
            orderUI.Name = orderModel.Name;
        }

        public void GenerateSchedule()
        {
            // Get order source and hours (calculated from order item total) from form.
            int hours = 400; // placeholder

            orderModel.GenerateSchedule(OrderSource.Entertainment, hours);
        }

        public void Save()
        {
            orderModel.State = OrderState.Enquiry;

            Submit();
        }

        public void Order()
        {
            orderModel.State = OrderState.Ordered;

            Submit();
        }

        private void Submit()
        {
            orderModel.Name = orderUI.Name;

            orderModel.CreateOrUpdate();
        }
    }
}
