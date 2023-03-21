using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Util;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;

namespace IronHelmTests.Tests.UtilTests
{
    [TestClass]
    public class UtilTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            CollectorScheduleModel testObject = new CollectorScheduleModel(); 

            //act

            CollectorScheduleModel clonedObject = Utils.DeepClone(testObject);

            //assert

            var serializedTestObject = JsonConvert.SerializeObject(testObject);
            var serialisedClonedObject = JsonConvert.SerializeObject(clonedObject);

            Assert.AreEqual(serialisedClonedObject, serializedTestObject);
        }
    }
}
