using Database;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Server.Controllers;
using Server.Models;
using Moq;
using Server;

namespace Tests
{
    [TestFixture]
    public class TestAccountController
    {
        private Mock<IWeatherDiaryRepository> repository = new Mock<IWeatherDiaryRepository>();
        [Test]
        public void TestLoginViewModelNotNull()
        {
            AccountController controller = new AccountController(repository.Object);
            ViewResult login = controller.Login() as ViewResult;
            Assert.IsNotNull(login);
        }

        [Test]
        public void TestRegisterViewModelNotNull()
        {
            AccountController controller = new AccountController(repository.Object);
            ViewResult register = controller.Register() as ViewResult;
            Assert.IsNotNull(register);
        }
    }

    public class TestDiaryController
    {
        private Mock<IWeatherDiaryRepository> repository = new Mock<IWeatherDiaryRepository>();

        // [Test]
        // public void TestShowViewModelNotNull()
        // {
        //     DiaryController controller = new DiaryController(repository.Object);
        //     ViewResult showModel = controller.Show() as ViewResult;
        //     Assert.IsNotNull(showModel);
        // }
    }
}