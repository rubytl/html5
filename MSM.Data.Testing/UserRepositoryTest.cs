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
    public class UserRepositoryTest
    {
        /// <summary>
        /// The mock site repo
        /// </summary>
        Mock<IUserMaintenanceRepository> mockUserRepo;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mockUserRepo = new Mock<IUserMaintenanceRepository>();
        }

        /// <summary>
        /// Adds the user test
        /// </summary>
        [TestMethod]
        public void AddUserTest()
        {
            bool addedSucess = false;
            var adddObj = new UserLoginConfiguration()
            {
                UserName = "Ruby"
            };

            this.mockUserRepo.Setup(s => s.AddAsync(It.IsAny<UserLoginConfiguration>())).Callback(() => { addedSucess = true; });
            this.mockUserRepo.Object.AddAsync(adddObj);
            Assert.IsTrue(addedSucess);
        }


        /// <summary>
        /// Deletes the user test
        /// </summary>
        [TestMethod]
        public void DeleteUserTest()
        {
            bool deleteSucess = false;
            var deletedObj = new UserLoginConfiguration()
            {
                UserName = "ruby"
            };

            this.mockUserRepo.Setup(s => s.Delete(It.IsAny<UserLoginConfiguration>())).Callback(() => { deleteSucess = true; });
            this.mockUserRepo.Object.Delete(deletedObj);
            Assert.IsTrue(deleteSucess);
        }

        /// <summary>
        /// Gets all user test
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetAllUserTest()
        {
            var expectedResult = Task.FromResult((new List<UserLoginConfiguration>() { new UserLoginConfiguration() { UserName = "ruby" } }).AsQueryable());
            this.mockUserRepo.Setup(s => s.GetAll()).Returns(expectedResult);
            var result = await this.mockUserRepo.Object.GetAll();
            Assert.AreEqual(expectedResult.Result, result);
        }


        /// <summary>
        /// Gets the single user test
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetSingleSiteTest()
        {
            var expectedResult = Task.FromResult(new UserLoginConfiguration() { UserName = "ruby" });
            this.mockUserRepo.Setup(s => s.GetSingleAsync(It.IsAny<Expression<Func<UserLoginConfiguration, bool>>>())).Returns(expectedResult);
            var result = await this.mockUserRepo.Object.GetSingleAsync(s => s.UserName == "ruby");
            Assert.AreEqual(expectedResult.Result, result);
        }
    }
}
