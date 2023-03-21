using IronHelmOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Models
{
    public interface IScheduleModel
    {
        int ScheduleItemID { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        int OrderID { get; set; }

        void GetSchedule(int orderID);

        void GenerateSchedule(int hours);

        void Create(int orderID);

        object Clone();
    }
}
