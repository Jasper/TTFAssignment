using Assignment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using TTFAssignment.Controllers;
using TTFAssignment.Models;

namespace TTFAssignment.Tests.Controllers
{
    [TestClass]
    public class BaseControllerTest
    {
        [TestMethod]
        public void TestS()
        {
            // Arrange
            BaseController controller = new BaseController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Input input = new Input();
            input.A = true;
            input.B = true;
            input.C = false;
            input.D = 5;
            input.E = 500;
            input.F = 100;

            // Act
            HttpResponseMessage response = controller.Index(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("S", output.X);
            Assert.AreEqual((decimal)30.0, output.Y);
        }

        [TestMethod]
        public void TestR()
        {
            // Arrange
            BaseController controller = new BaseController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Input input = new Input();
            input.A = true;
            input.B = true;
            input.C = true;
            input.D = 5;
            input.E = 500;
            input.F = 100;

            // Act
            HttpResponseMessage response = controller.Index(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("R", output.X);
            Assert.AreEqual((decimal)25.0, output.Y);
        }

        [TestMethod]
        public void TestT()
        {
            // Arrange
            BaseController controller = new BaseController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Input input = new Input();
            input.A = false;
            input.B = true;
            input.C = true;
            input.D = 5;
            input.E = 500;
            input.F = 100;

            // Act
            HttpResponseMessage response = controller.Index(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("T", output.X);
            Assert.AreEqual((decimal)0.0, output.Y);
        }

        [TestMethod]
        public void TestError()
        {
            // Arrange
            BaseController controller = new BaseController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Input input = new Input();
            input.A = false;
            input.B = false;
            input.C = false;
            input.D = 5;
            input.E = 500;
            input.F = 100;

            // Act
            HttpResponseMessage response = controller.Index(input);

            String output;
            Assert.IsTrue(response.TryGetContentValue<String>(out output));

            // Assert
            Assert.AreEqual("error", output);
        }
    }
}
