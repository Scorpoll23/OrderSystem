using Microsoft.VisualStudio.TestTools.UnitTesting;
using IronHelmOrderSystem.Models;
using System;
using IronHelmTests.Tests.Mocs;

namespace IronHelmTests
{
    [TestClass]
    public class ClientModelTests
    {
        [TestMethod]
        public void TestGetName()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act / assert

            Assert.AreEqual<String>("Tim", testClientModel.GetName());
        }

        [TestMethod]
        public void TestGetClientID()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(1, testClientModel.GetClientID());
        }

        [TestMethod]
        public void TestGetNumberorName()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(testClientModel.GetNumberOrName(), "NumberOrName");
        }

        [TestMethod]
        public void TestGetAddressline1()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(testClientModel.GetAddressLine1(), "1 Street Rd");
        }

        [TestMethod]
        public void TestGetAddressline2()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(testClientModel.GetAddressLine2(), "House Palace");
        }

        [TestMethod]
        public void TestGetPostcode()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(testClientModel.GetPostcode(), "NE12345");
        }

        [TestMethod]
        public void TestGetCountry()
        {
            //arrange

            IClientModel testClientModel = new ClientModelMoc();

            //act

            Assert.AreEqual(testClientModel.GetCountry(), "UK");
        }

        [TestMethod]
        public void TestGetClientByID()
        {
            //arrange

            ClientModelMoc testClientModel = new ClientModelMoc();
            int clientID = testClientModel.GetClientID();
            testClientModel.SetName("Tim");

            ClientModelMoc testClientModel2 = new ClientModelMoc();

            //act

            testClientModel2.GetClientById(clientID);

            //asseret

            Assert.AreEqual(testClientModel2.GetName(), "Tim");
        }
    }
}
