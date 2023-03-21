using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronHelmOrderSystem.Entities.Enum;

namespace IronHelmOrderSystem.Models
{
    public interface IOrderModel
    {
        int OrderID { get; set; }

        string Name { get; set; }

        OrderSource Source { get; set; }

        OrderState State { get; set; }

        DateTime EnquiryDate { get; set; }

        DateTime Deadline { get; set; }

        DateTime OrderDate { get; set; }

        byte Progress { get; set; }

        IClientModel Client { get; set; }

        IScheduleModel Schedule { get; set; }

        IEnumerable<IOrderItemModel> OrderItems { get; set; }

        void GetOrderById(int orderID);

        void GenerateSchedule(OrderSource orderSource, int hours);

        void CreateOrUpdate();
    }
}
