using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var recordViewModel = new RecordViewModel()
            {
                DisplayViewModel = new List<RecordInputViewModel>()
                {
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date1", Description = "Desc1", Money = "7788" },
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date2", Description = "Desc2", Money = "7789" },
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date3", Description = "Desc3", Money = "7790" },
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date4", Description = "Desc4", Money = "7791" },
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date5", Description = "Desc5", Money = "7792" },
                    new RecordInputViewModel()
                        { Category = EnumCategory.Income, Date = "date6", Description = "Desc6", Money = "7793" },
                }
            };
            return recordViewModel;
        }

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