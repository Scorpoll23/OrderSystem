using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Util;

namespace IronHelmOrderSystem.Models
{
    [Serializable]
    public abstract class ScheduleModel : IScheduleModel, ICloneable
    {
        public int ScheduleItemID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int OrderID { get; set; }

        public void GetSchedule(int orderID)
        {
            ScheduleItem item = GetScheduleItemByOrderID(orderID);

            if (item != null)
            {
                ScheduleItemID = item.ScheduleItemID;
                StartDate = item.StartDate;
                EndDate = item.EndDate;
                OrderID = item.Order.OrderID;
            }
        }

        private ScheduleItem GetScheduleItemByOrderID(int orderID)
        {
            ScheduleItem scheduleItem;

            using (var ctx = new DatabaseEntities())
                scheduleItem = ctx.ScheduleItems.SingleOrDefault(x => x.Order.OrderID == orderID);

            return scheduleItem;
        }

        public void GenerateSchedule(int hours)
        {
            ScheduleItem item = GetNextTimeSlot(hours);

            StartDate = item.StartDate;
            EndDate = item.EndDate;
        }

        protected abstract ScheduleItem GetNextTimeSlot(int hours);

        public void Create(int orderID)
        {
            // Set OrderID
            OrderID = orderID;

            if (OrderID != 0 && StartDate != DateTime.MinValue && EndDate != DateTime.MinValue)
            {
                // Get all schedule items after the start date of the item to insert.
                var scheduleItems = GetScheduleItems(StartDate);

                // If there are any, move schedule items forward.
                if (scheduleItems.Count > 0)
                    MoveScheduleItemsForward(scheduleItems, ScheduleHelper.AddWorkingDays(EndDate, 1));

                // Add new item.
                InsertScheduleItem();
            }
        }

        private List<ScheduleItem> GetScheduleItems(DateTime fromDate)
        {
            List<ScheduleItem> scheduleItems;

            using (var ctx = new DatabaseEntities())
            {
                scheduleItems = ctx.ScheduleItems.Where(x => x.StartDate >= fromDate)
                    .OrderByDescending(x => x.EndDate)
                    .ToList();
            }

            return scheduleItems;
        }

        private void MoveScheduleItemsForward(List<ScheduleItem> scheduleItems, DateTime initialStartDate)
        {
            // Set schedule shift initial start date.
            DateTime startDate = initialStartDate;

            DateTime endDate;

            using (var ctx = new DatabaseEntities())
            {
                foreach (ScheduleItem scheduleItem in scheduleItems)
                {
                    var item = ctx.ScheduleItems.SingleOrDefault(x => x.ScheduleItemID == scheduleItem.ScheduleItemID);

                    if (item != null)
                    {
                        // Get workings days of this entry.
                        int workingDays = ScheduleHelper.GetWorkingDays(item.StartDate, item.EndDate);

                        // Set new start date as the end date of previous iteration.
                        item.StartDate = startDate;

                        // Re-calculate end date (minus one day to account for start date).
                        endDate = ScheduleHelper.AddWorkingDays(startDate, workingDays - 1);
                        item.EndDate = endDate;

                        // Set start date as the end date of this iteration plus one day.
                        startDate = ScheduleHelper.AddWorkingDays(endDate, 1);

                        ctx.SaveChanges();
                    }
                }
            }
        }

        private void InsertScheduleItem()
        {
            using (var ctx = new DatabaseEntities())
            {
                var order = ctx.Orders.SingleOrDefault(x => x.OrderID == this.OrderID);

                if (order != null)
                {
                    ctx.ScheduleItems.Add(new ScheduleItem()
                    {
                        StartDate = this.StartDate,
                        EndDate = this.EndDate,
                        Order = order
                    });

                    ctx.SaveChanges();
                }
            }
        }

        public abstract object Clone();
    }
}
