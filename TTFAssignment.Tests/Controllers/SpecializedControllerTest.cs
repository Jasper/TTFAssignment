using Assignment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TTFAssignment.Controllers;

namespace TTFAssignment.Tests.Controllers
{
    [TestClass]
    public class SpecializedControllerTest
    {
        [TestMethod]
        public void TestOneR()
        {
            // Arrange
            SpecializedController controller = new SpecializedController();
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
            HttpResponseMessage response = controller.One(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("R", output.X);
            Assert.AreEqual((decimal)35.0, output.Y);
        }

        [TestMethod]
        public void TestTwoT()
        {
            // Arrange
            SpecializedController controller = new SpecializedController();
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
            HttpResponseMessage response = controller.Two(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("T", output.X);
            Assert.AreEqual((decimal)0.0, output.Y);
        }

        [TestMethod]
        public void TestTwoS()
        {
            // Arrange
            SpecializedController controller = new SpecializedController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Input input = new Input();
            input.A = true;
            input.B = false;
            input.C = true;
            input.D = 5;
            input.E = 500;
            input.F = 100;

            // Act
            HttpResponseMessage response = controller.Two(input);

            Output output;
            Assert.IsTrue(response.TryGetContentValue<Output>(out output));

            // Assert
            Assert.AreEqual("S", output.X);
            Assert.AreEqual((decimal)130.0, output.Y);
        }

        [TestMethod]
        public void TestError()
        {
            // Arrange
            SpecializedController controller = new SpecializedController();
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
            HttpResponseMessage response = controller.One(input);
            HttpResponseMessage responseTwo = controller.Two(input);

            String output;
            Assert.IsTrue(response.TryGetContentValue<String>(out output));

            String outputTwo;
            Assert.IsTrue(response.TryGetContentValue<String>(out outputTwo));


            // Assert
            Assert.AreEqual("error", output);
            Assert.AreEqual("error", outputTwo);
        }
    }
}
