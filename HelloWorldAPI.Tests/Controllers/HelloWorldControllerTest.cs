using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    /// <summary>
    /// Summary description for HelloWorldControllerTest
    /// </summary>
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            HelloWorldController controller = new HelloWorldController();

            string result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
        }
    }
}
