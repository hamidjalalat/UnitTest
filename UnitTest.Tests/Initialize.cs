using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Tests
{
    [TestClass]
    public class Initialize
    {
        public Initialize()
        {

        }
        public TestContext TestContext { get; set; }

        //حتما باید تابع استاتیک باشد
        //فقط یک بار در زمان اجرای کلاس تست اتفاق می افتد
        [ClassInitialize()]
        public static void googooli_ClassInitialize(TestContext ss)
        {
            Debug.WriteLine($"{ss.FullyQualifiedTestClassName}- ClassInitialize");
        }

        //به تعداد تابع تست موجود در کلاس اجرا می شود
        [TestInitialize()]
        public  void googooli_TestInitialize()
        {
            Debug.WriteLine($"{TestContext.TestName}- TestInitialize");
        }


        //به تعداد تابع تست موجود در کلاس هنگامی که تابع اجراش به پایان رسید  اجرا می شود
        [TestCleanup()]
        public void googooli_TestCleanup()
        {
            Debug.WriteLine($"{TestContext.TestName}- TestCleanup");
        }


        //حتما باید تابع استاتیک باشد
        //وقتی کالس تست به پایان رسید اجرا می شود
        [ClassCleanup()]
        public static void googooli_ClassCleanup()
        {
            Debug.WriteLine( "ClassCleanup");
        }



        //حتما باید یک متد تست نوشته شود تا متد های بالا اجرا شود
        [TestMethod]
        public void Methodtest()
        {
            Debug.WriteLine("execute test");
        }
      
    }
}
