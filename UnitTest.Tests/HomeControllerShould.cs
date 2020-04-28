using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
{
    [TestClass]
    public class HomeControllerShould
    {
        //می خواهیم تست کنیم که اکشن حتما ویو برگرداند
        [TestMethod]
        public void TestMethod1()
        {
            //Arrrange
            UnitTest.Controllers.HomeController HomeController = new Controllers.HomeController();

            //act
            ActionResult result= HomeController.Index();

            //assret
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        //می خواهیم تست کنیم که ویو بگ پیامی که ما می خواهم را نشان می دهد
        [TestMethod]
        public void TestMethod2()
        {
            //Arrrange
            UnitTest.Controllers.HomeController HomeController = new Controllers.HomeController();

            //act
            //برای بدست آوردن ویو بگ حتما باید به ویو ریزات کست شود
            ViewResult result = HomeController.Test2() as ViewResult;

            string expected ="HamidJalalat";
            string actual = result.ViewBag.Message;
            //assret
            Assert.AreEqual(expected: expected, actual: actual);
        }
        //می خواهیم تست کنیم که ویو استیت ما اگر اوکی نبود درست کار می کند
        //توجه بای داشته باشیم که خودمان باید به ویو استیت خطا اضافه کنیم
        [TestMethod]
        public void TestMethod3()
        {
            //Arrrange
            UnitTest.Controllers.HomeController HomeController = new Controllers.HomeController();
            Models.User user = new Models.User();
            HomeController.ModelState.AddModelError("googloli", "magooli");

            //act

            ViewResult result = HomeController.Test3(user) as ViewResult;
           

            string expected = "Error";
            string actual = result.ViewBag.Message;
            //assret
            Assert.AreEqual(expected: expected, actual: actual);
        }
    }
}
