using Dotnet_Practical_09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dotnet_Practical_09.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            MessageModel model=new MessageModel();
            model.Message = "Hello World!";

            return View(model);
        }

       
    }
}