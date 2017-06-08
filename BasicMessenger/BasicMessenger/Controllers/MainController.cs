using System;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        // default path --> /[Controller]/[ActionName]/[Parameters]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name) {
            ViewBag.Message = $"hello, {name}!";
            return View();

        }

        //public string Welcome(int id, string name)
        //{
        //    // string interpolation
        //    // instead of String.Format("welcome {1}", name);
        //    // + protection agains malicous input
        //    // http://localhost:52025/main/welcome/5?name=someName --> welcome someName, id: 5
        //    return HttpUtility.HtmlEncode($"welcome {name}, id: {id}");
        //}

        public ActionResult LogIn()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}