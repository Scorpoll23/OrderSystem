using System;
using System.Collections.Generic;
using System.Linq;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Util;

namespace IronHelmOrderSystem.Models
{
    public class OrderModel : IOrderModel
    { 
        public int OrderID { get; set; }

        public string Name { get; set; }

        public OrderSource Source { get; set; }

        public OrderState State { get; set; }

        public DateTime EnquiryDate { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime OrderDate { get; set; }

        public byte Progress { get; set; }

        public IClientModel Client { get; set; }

        public IScheduleModel Schedule { get; set; }

        public IEnumerable<IOrderItemModel> OrderItems { get; set; }

        public OrderModel()
        {
            this.Client = new ClientModel();
            this.OrderItems = new List<OrderItemModel>();
        }

        public OrderModel(int orderID)
        {
            this.Client = new ClientModel();
            this.OrderItems = new List<OrderItemModel>();

            GetOrderById(orderID);
        }

        public void GenerateSchedule(OrderSource orderSource, int hours)
        {
            Schedule = ScheduleFactory.Instance.GetSchedule(orderSource);
            Schedule.GenerateSchedule(hours);
        }

        public void CreateOrUpdate()
        {
            // Convert model to entity.
            var order = FromModel();

            // Placeholder for order creation / update. Make sure to retrieve order id for schedule's ref.
            int orderID = 5;

            // Create Schedule Entry when 'ordered'
            if (order.State == OrderState.Ordered)
                Schedule.Create(orderID);
        }

        public void GetOrderById(int orderID)
        {
            using (var ctx = new DatabaseEntities())
            {
                var order = ctx.Orders.SingleOrDefault(x => x.OrderID == orderID);

                if (order != null)
                {
                    ToModel(order);

                    Schedule = ScheduleFactory.Instance.GetSchedule(order.Source);
                    Schedule.GetSchedule(order.OrderID);
                }
            }
        }

        private void ToModel(Order order)
        {
            OrderID = order.OrderID;
            Name = order.Name;         
            Source = order.Source;
            State = order.State;

            //Client.Name = order.Client.Name;
        }

        private Order FromModel()
        {
            Order order = new Order();
            order.OrderID = OrderID;
            order.Name = Name;
            order.Source = Source;
            order.State = State;
            order.Client = new Client
            {
                Name = Client.GetName()
            };

            return order;
        }
    }
}
