using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Homework_SkillTree.Enums;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(CreateRecordViewModel());
        }

        private static RecordViewModel CreateRecordViewModel()
        {
            var recordViewModel = new RecordViewModel { DisplayViewModel = new List<RecordInputViewModel>() };
            var rnd = new Random();
            for (var i = 0; i < 101; i++)
            {
                recordViewModel.DisplayViewModel.Add(new RecordInputViewModel()
                {
                    Category = (EnumCategory)(rnd.Next(i) % 2),
                    Date = new DateTime(1995, 1, 1).AddDays(rnd.Next((DateTime.Today - new DateTime(1995, 1, 1)).Days)).Date,
                    Description = $"desc{rnd.Next(i + 2) % 5}",
                    Money = $"{rnd.Next(i + 777) * 5}"
                });
            }
            return recordViewModel;
        }

        public static DateTime Date { get; set; }

        [HttpPost]
        public ActionResult Index(RecordViewModel model)
        {
            return View(CreateRecordViewModel());
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