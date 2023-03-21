using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using IronHelmOrderSystem.Util;
using IronHelmOrderSystem.Entities;
using System.IO;

namespace IronHelmTests.Tests.UtilTests
{
    [TestClass]
    public class RepositryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", dir);

            Repository testRepositry = new Repository();

            Client testClient = new Client();

            testClient.Name = "TestClient1";
            testClient.ClientID = 999999999;

            using (var ctx = new DatabaseEntities())
            {
                ctx.Clients.Add(testClient);
            }
                
            //act

            List<Client> testClientList = testRepositry.GetAllClients();

            //assert

            Assert.IsNotNull(testClientList, "Client list is null");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", dir);

            Repository testRepositry = new Repository();

            Client testClient1 = new Client();

            Order testOrder1 = new Order();
            Order testOrder2 = new Order();

            testOrder1.Client = testClient1;
            testOrder2.Client = testClient1;

            //act

            List<Order> testClient1Orders =  testRepositry.GetOrdersByClientID(testClient1.ClientID);
            Console.WriteLine(testClient1Orders.Count);

            //assert

            //Assert.IsTrue(testClient1Orders.Contains(testOrder1));
            //Assert.IsTrue(testClient1Orders.Contains(testOrder2));
            //Assert.IsTrue(testClient1Orders.Count == 2);
        }
    }
}
