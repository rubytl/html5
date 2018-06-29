using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Testing
{
    /// <summary>
    /// The AlarmRepositoryTest class
    /// </summary>
    [TestClass]
    public class AlarmRepositoryTest
    {
        /// <summary>
        /// The mock alarm repo
        /// </summary>
        Mock<IAlarmRepository> mockAlarmRepo;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mockAlarmRepo = new Mock<IAlarmRepository>();
        }

        /// <summary>
        /// Adds the SNMP reciver test.
        /// </summary>
        [TestMethod]
        public void AddSNMPReciverTest()
        {
            bool addedSucess = false;
            var adddObj = new SnmpreceiverHistory()
            {
                AlarmDescription = "Alarm",
                Ipaddress = "10.20.7.238"
            };

            this.mockAlarmRepo.Setup(s => s.AddAsync(It.IsAny<SnmpreceiverHistory>())).Callback(() => { addedSucess = true; });
            this.mockAlarmRepo.Object.AddAsync(adddObj);
            Assert.IsTrue(addedSucess);
        }


        /// <summary>
        /// Deletes the SNMP reciver test.
        /// </summary>
        [TestMethod]
        public void DeleteSNMPReciverTest()
        {
            bool deleteSucess = false;
            var deletedObj = new SnmpreceiverHistory()
            {
                AlarmDescription = "Alarm",
                Ipaddress = "10.20.7.238"
            };

            this.mockAlarmRepo.Setup(s => s.Delete(It.IsAny<SnmpreceiverHistory>())).Callback(() => { deleteSucess = true; });
            this.mockAlarmRepo.Object.Delete(deletedObj);
            Assert.IsTrue(deleteSucess);
        }

        /// <summary>
        /// Gets all SNMP reciver test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetAllSNMPReciverTest()
        {
            var expectedResult = Task.FromResult((new List<SnmpreceiverHistory>() { new SnmpreceiverHistory() { AlarmDescription = "Alarm", Ipaddress = "10.20.7.238" } }).AsQueryable());
            this.mockAlarmRepo.Setup(s => s.GetAll()).Returns(expectedResult);
            var result = await this.mockAlarmRepo.Object.GetAll();
            Assert.AreEqual(expectedResult.Result, result);
        }


        /// <summary>
        /// Gets the single SNMP reciver test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetSingleSNMPReciverTest()
        {
            var expectedResult = Task.FromResult(new SnmpreceiverHistory() { AlarmDescription = "Alarm", Ipaddress = "10.20.7.238" });
            this.mockAlarmRepo.Setup(s => s.GetSingleAsync(It.IsAny<Expression<Func<SnmpreceiverHistory, bool>>>())).Returns(expectedResult);
            var result = await this.mockAlarmRepo.Object.GetSingleAsync(s => s.AlarmDescription == "Alarm");
            Assert.AreEqual(expectedResult.Result, result);
        }

        /// <summary>
        /// Gets the filtered SNMP receiver history test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetFilteredSNMPReceiverHistoryTest()
        {
            var expectedResult = Task.FromResult((new List<SnmpreceiverHistory>() { new SnmpreceiverHistory() { AlarmDescription = "Alarm", Ipaddress = "10.20.7.238" } }).AsQueryable());
            this.mockAlarmRepo.Setup(s => s.GetFilteredSNMPReceiverHistory(It.IsAny<List<int>>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<long>())).Returns(expectedResult);
            var result = await this.mockAlarmRepo.Object.GetFilteredSNMPReceiverHistory(null, null, null, 10);
            Assert.AreEqual(expectedResult.Result, result);
        }
    }
}
