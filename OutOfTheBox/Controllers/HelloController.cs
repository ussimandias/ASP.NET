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
        public ActionResult Index()
        {
	        return View();
        }

        public ActionResult HelloMyName(string name, int numHellos = 1)
        {
	        ViewBag.Message = "Hello " + name;
	        ViewBag.NumHelloes = numHellos;

	        return View();
        }

        public string Html()
        {
            return "This is an <b>HTML</b> string..";
        }

        public string HelloWorld()
        {
            return "Hello World!.. ";
        }

        //Passing Parameters to an Action

        public string HelloName(string name, int howMany)
        {
            return "Hello World!.. " + name  +". "  + howMany + " times!";
        }

	    public string Name(string name, int ID = 1)
	    {
		    return HttpUtility.HtmlEncode("Hello World!.. " + name + ". " + ID + " times!");
	    }
    }
}