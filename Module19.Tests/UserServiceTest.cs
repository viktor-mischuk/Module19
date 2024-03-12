using Module19.BLL.Exceptions;
using Module19.BLL.Models;
using Module19.BLL.Services;
using Module19.DAL.Entities;
using Module19.DAL.Repositories;
using Module19.PLL.Views;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net.Mail;

namespace Module19.Tests
{
    [TestFixture]
    public class UserServiceTest
    {
        [Test]
        public void RegisterException()
        {
            UserRegistrationData userRegistrationData = new UserRegistrationData()
            {
                FirstName = "",
                LastName = "",
                Password = "",
                Email = ""
            };
            
            UserService userService = new UserService();

            Assert.Throws<ArgumentNullException>( () => userService.Register(userRegistrationData));

        }
    }
}
