using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Util;
using System;
using System.Linq;

namespace IronHelmOrderSystem.Models
{
    [Serializable]
    public class CollectorScheduleModel : ScheduleModel
    {
        public CollectorScheduleModel()
        {

        }

        public static void RegisterSchedule()
        {
            ScheduleFactory.Instance.RegisterSchedule(OrderSource.Collector, new CollectorScheduleModel());
        }

        protected override ScheduleItem GetNextTimeSlot(int hours)
        {
            ScheduleItem nextSlot = new ScheduleItem();

            using (var ctx = new DatabaseEntities())
            {
                var lastSlot = ctx.ScheduleItems.Join(ctx.Orders, si => si.Order.OrderID, o => o.OrderID, (si, o) => new { si, o })
                    .Select(x => new { x.o.Name, x.o.Source, x.si.StartDate, x.si.EndDate })
                    .OrderByDescending(x => x.EndDate)
                    .FirstOrDefault();

                if (lastSlot != null)
                {
                    // Start Date of new proposed slot will be at the end of the latest slot plus one working day.
                    nextSlot.StartDate = ScheduleHelper.AddWorkingDays(lastSlot.EndDate, 1);
                }
                else
                {
                    // No slot found, consider start date as today's date.
                    nextSlot.StartDate = DateTime.UtcNow.Date;
                }

                // End Date of the new proposed slot will be calculated using the proposed hours and artisans hours/availability.
                nextSlot.EndDate = ScheduleHelper.GetEndDate(nextSlot.StartDate, hours);
            }

            return nextSlot;
        }

        public override object Clone()
        {
            return Utils.DeepClone(this);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(CollectorScheduleModel)) return false;
            return Equals((CollectorScheduleModel)obj);
        }
    }
}
