using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutOfTheBox.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "This is an <b>HTML</b> string..";
        }

        public string HelloWorld()
        {
            return "Hello World!.. ";
        }
    }
}