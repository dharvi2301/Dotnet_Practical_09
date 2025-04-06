using Dotnet_Practical_09.Controllers;
using Dotnet_Practical_09.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Dotnet_Practical_09_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index_ReturnsHelloWorldModel()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as MessageModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("Hello World!", model.Message);
        }
    }
}
