using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTest
{
    public class Service : IService
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SendSms(string text)
        {
            //این تابع در هر صورت hamid jalalat برمی گرونه
            //ولی با Mock می بینید تغییر می کنه
            return "Hamid jalalat";
        }
    }
}