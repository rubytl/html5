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
    /// The SiteRepositoryTest class
    /// </summary>
    [TestClass]
    public class SiteRepositoryTest
    {
        /// <summary>
        /// The mock site repo
        /// </summary>
        Mock<ISiteRepository> mockSiteRepo;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mockSiteRepo = new Mock<ISiteRepository>();
        }

        /// <summary>
        /// Adds the site test.
        /// </summary>
        [TestMethod]
        public void AddSiteTest()
        {
            bool addedSucess = false;
            var adddObj = new Site()
            {
                Address = "10.20.7.238",
                Description = "Drammen"
            };

            this.mockSiteRepo.Setup(s => s.AddAsync(It.IsAny<Site>())).Callback(() => { addedSucess = true; });
            this.mockSiteRepo.Object.AddAsync(adddObj);
            Assert.IsTrue(addedSucess);
        }


        /// <summary>
        /// Deletes the site test.
        /// </summary>
        [TestMethod]
        public void DeleteSiteTest()
        {
            bool deleteSucess = false;
            var deletedObj = new Site()
            {
                Address = "10.20.7.238",
                Description = "Drammen"
            };

            this.mockSiteRepo.Setup(s => s.Delete(It.IsAny<Site>())).Callback(() => { deleteSucess = true; });
            this.mockSiteRepo.Object.Delete(deletedObj);
            Assert.IsTrue(deleteSucess);
        }

        /// <summary>
        /// Gets all site test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetAllSiteTest()
        {
            var expectedResult = Task.FromResult((new List<Site>() { new Site() { Address = "10.20.7.238", Description = "Drammen" } }).AsQueryable());
            this.mockSiteRepo.Setup(s => s.GetAll()).Returns(expectedResult);
            var result = await this.mockSiteRepo.Object.GetAll();
            Assert.AreEqual(expectedResult.Result, result);
        }


        /// <summary>
        /// Gets the single site test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetSingleSiteTest()
        {
            var expectedResult = Task.FromResult(new Site() { Address = "10.20.7.238", Description = "Drammen" });
            this.mockSiteRepo.Setup(s => s.GetSingleAsync(It.IsAny<Expression<Func<Site, bool>>>())).Returns(expectedResult);
            var result = await this.mockSiteRepo.Object.GetSingleAsync(s => s.Description == "Drammen");
            Assert.AreEqual(expectedResult.Result, result);
        }

        /// <summary>
        /// Gets the site list filtered test.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetSiteListFilteredTest()
        {
            Mock<ISiteRepository> mockSiteRepo = new Mock<ISiteRepository>();
            var expectedResult = Task.FromResult((new List<Site>() { new Site() { Address = "10.20.7.238", Description = "Drammen" } }).AsQueryable());
            mockSiteRepo.Setup(s => s.GetSiteListFiltered(It.IsAny<int>(), It.IsAny<string>())).Returns(expectedResult);
            var result = await mockSiteRepo.Object.GetSiteListFiltered(0, "Drammen");
            Assert.AreEqual(expectedResult.Result, result);
        }
    }
}
