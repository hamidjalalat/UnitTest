using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTest.Controllers
{
    public class UseServiceController : Controller
    {
        public UseServiceController()
        {
            Service = new Service();
        }
        public UseServiceController(IService service)
        {
            Service = service;
        }
        public IService Service { get; set; }
        // GET: UseService
        public string SendMessage()
        {
            //من به نام مگولی دادم ولی ماک این هم عوض می کنه
            Service.Name = "مگولی";

            string result = Service.SendSms("hamid");
            if (result=="jalal")
            {
                return "jalal";
            }
            return "hich";
        }
    }
}