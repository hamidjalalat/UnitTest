using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Controllers;

namespace UnitTest.Tests
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock =new  Moq.Mock<IService>();

            //این روش یعنی تمام فیلده و متد ها باید حتما پر شود وگرنه خطا میدهد
            //var mock = new Moq.Mock<IService>(Moq.MockBehavior.Strict);

            //یعنی نام رو jalal پرش کن
            mock.Setup(C => C.Name).Returns("jalal");

            //Moq.It.IsAny<string>())یعنی با هر ورودی
            mock.Setup(C => C.SendSms(Moq.It.IsAny<string>())).Returns("jalal");

            UseServiceController result = new UseServiceController(mock.Object);


            string expected = result.SendMessage();

            string actual = "jalal";

            Assert.AreEqual(expected, actual);
        }
    }
}
