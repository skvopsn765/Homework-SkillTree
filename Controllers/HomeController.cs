using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<MoneyRecord> _moneyRecords = new List<MoneyRecord>();

        public ActionResult Index()
        {
            SetViewDataSelectList();
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string category, string money, string date, string description)
        {
            SetViewDataSelectList();
            _moneyRecords.Add(new MoneyRecord() { Category = category, Money = money, Date = date, Description = description });
            return View();
        }
        
        private void SetViewDataSelectList()
        {
            var items = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "請選擇", Value = "請選擇", Selected = true },
                new SelectListItem() { Text = "支出", Value = "支出" },
                new SelectListItem() { Text = "收入", Value = "收入" },
            };

            ViewData["dr"] = items;
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