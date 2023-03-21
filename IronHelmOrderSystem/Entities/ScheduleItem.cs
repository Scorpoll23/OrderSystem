using System;
using System.ComponentModel.DataAnnotations;

namespace IronHelmOrderSystem.Entities
{
    public class ScheduleItem
    {
        [Key]
        public int ScheduleItemID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Order Order { get; set; }

        public ScheduleItem()
        {

        }
    }
}