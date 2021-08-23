using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var items = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "請選擇", Value = "請選擇", Selected = true},
                new SelectListItem() {Text = "支出", Value = "支出"},
                new SelectListItem() {Text = "收入", Value = "收入"},
            };
            
            ViewData["dr"] = items;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string category, string money, string date, string description)
        {
            var items = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "請選擇", Value = "請選擇", Selected = true},
                new SelectListItem() {Text = "支出", Value = "支出"},
                new SelectListItem() {Text = "收入", Value = "收入"},
            };
            
            ViewData["dr"] = items;
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