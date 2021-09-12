using System;
using System.Web.Mvc;
using Homework_SkillTree.Helper;
using Homework_SkillTree.Models;
using Homework_SkillTree.Service;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Model1 Model1 = IocHelper.Resolve<Model1>();
        private readonly AccountService _accountService;

        public HomeController()
        {
            _accountService = new AccountService(Model1);
        }

        [HttpGet]
        public ActionResult Index(RecordInputViewModel inputViewModel)
        {
            var recordViewModel = _accountService.GetRecordViewModel();
            recordViewModel.InputViewModel = inputViewModel;
            return View(recordViewModel);
        }

        [HttpPost]
        public ActionResult Submit(RecordInputViewModel inputViewModel)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(inputViewModel);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", inputViewModel);
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

        public ActionResult CheckDate([Bind(Prefix = "inputViewModel.Date")] DateTime? date, string test)
        {
            if (date <= DateTime.Today.Date)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json("日期不可以超過今天！", JsonRequestBehavior.AllowGet);
        }
    }
}