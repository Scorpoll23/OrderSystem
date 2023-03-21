using Microsoft.VisualStudio.TestTools.UnitTesting;
using IronHelmOrderSystem.Util;
using System;
using IronHelmOrderSystem.Entities.Enum;
using IronHelmOrderSystem.Models;

namespace IronHelmTests.Tests.UtilTests
{
    [TestClass]
    public class ScheduleFactoryTests
    {
        [TestMethod]
        public void TestMethod0()
        {
            //assert

            Assert.IsNull(ScheduleFactory.Instance.GetSchedule(OrderSource.Entertainment));
        }
        [TestMethod]
        public void TestMethod1()
        {
            //act

            ScheduleFactory.Instance.RegisterSchedule(OrderSource.Collector, new CollectorScheduleModel());

            //assert

            Assert.IsNotNull(ScheduleFactory.Instance.GetSchedule(OrderSource.Collector));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //act

            ScheduleFactory.Instance.RegisterSchedule(OrderSource.Entertainment, new CollectorScheduleModel());

            //assert

            Assert.IsNotNull(ScheduleFactory.Instance.GetSchedule(OrderSource.Entertainment));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //act

            ScheduleFactory.Instance.RegisterSchedule(OrderSource.Governmental, new CollectorScheduleModel());

            //assert

            Assert.IsNotNull(ScheduleFactory.Instance.GetSchedule(OrderSource.Governmental));
        }
    }
}
