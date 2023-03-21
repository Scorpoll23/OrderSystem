using System.Collections;
using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Models;

namespace IronHelmOrderSystem.Util
{
    public class ScheduleFactory
    {
        private readonly Hashtable ScheduleMapping = new Hashtable();

        private static ScheduleFactory instance { get; set; }

        public static ScheduleFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScheduleFactory();

                return instance;
            }
        }

        private ScheduleFactory()
        {
        }

        public void RegisterSchedule(OrderSource orderSource, IScheduleModel schedule)
        {
            if (!ScheduleMapping.ContainsKey(orderSource))
                ScheduleMapping[orderSource] = schedule;
        }

        public IScheduleModel GetSchedule(OrderSource orderSource)
        {
            IScheduleModel schedule = null;
            if (ScheduleMapping.ContainsKey(orderSource))
                schedule = (IScheduleModel)ScheduleMapping[orderSource];
            return (IScheduleModel)schedule.Clone();
        }
    }
}
