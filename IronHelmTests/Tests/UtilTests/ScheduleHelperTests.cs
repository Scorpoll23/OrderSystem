using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IronHelmOrderSystem.Util;

namespace IronHelmTests.Tests.UtilTests
{
    [TestClass]
    public class ScheduleHelperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            DateTime startDate = new DateTime(2022, 01, 10);
            int hours = 150;
            DateTime expectedEndDate = new DateTime(2022, 01, 12);
            
            //act

            DateTime actualEndDate = (DateTime)ScheduleHelper.GetEndDate(startDate, hours);

            //assert

            Assert.AreEqual(expectedEndDate, actualEndDate);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange

            DateTime startDate = new DateTime(2022, 01, 10);
            DateTime expectedEndDate = new DateTime(2022, 01, 12);

            //act

            DateTime actualEndDate = ScheduleHelper.AddWorkingDays(startDate, 2);

            //assert

            Assert.AreEqual(expectedEndDate, actualEndDate);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange

            DateTime startDate = new DateTime(2022, 01, 14);
            DateTime expectedEndDate = new DateTime(2022, 01, 17);

            //act

            DateTime actualEndDate = ScheduleHelper.AddWorkingDays(startDate, 1);

            //assert

            Assert.AreEqual(expectedEndDate, actualEndDate);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange

            DateTime startDate = new DateTime(2022, 01, 13);
            DateTime endDate = new DateTime(2022, 01, 20);
            int expectedDays = 6;

            //act

            int actualDays = ScheduleHelper.GetWorkingDays(startDate, endDate);

            //assert

            Assert.AreEqual(expectedDays, actualDays);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange

            DateTime startDate = new DateTime(2022, 01, 10);
            DateTime endDate = new DateTime(2022, 01, 12);
            int expectedDays = 3;

            //act

            int actualDays = ScheduleHelper.GetWorkingDays(startDate, endDate);

            //assert

            Assert.AreEqual(expectedDays, actualDays);

        }
    }
}
