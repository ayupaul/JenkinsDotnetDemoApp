using JenkinsDotnetDemoApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DemoTest
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController controller = new HomeController();
        [TestMethod]
        public void IndexTest()
        {
            var result=controller.Index() as ViewResult;
            Assert.AreEqual("Index", result?.ViewName);

        }
        [TestMethod]
        public void PrivacyTest()
        {
            var result = controller.Privacy() as ViewResult;
            Assert.AreEqual("Privacy", result?.ViewName);
        }
    }
}