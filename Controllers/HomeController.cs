using System;
using System.Web.Mvc;
using Homework_SkillTree.Helper;
using Homework_SkillTree.Models;
using Homework_SkillTree.Service;
using X.PagedList;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        private const int PageSize = 20;
        private static readonly Model1 Model1 = IocHelper.Resolve<Model1>();
        private readonly AccountService _accountService;

        public HomeController()
        {
            _accountService = new AccountService(Model1);
        }

        [HttpGet]
        public ActionResult Index(InputViewModel inputViewModel)
        {
            return View(inputViewModel);
        }

        [HttpGet]
        public ActionResult ShowRecord(int page = 1)
        {
            var pagedRecord = GetPagedRecord(page);
            return View(pagedRecord);
        }

        private object GetPagedRecord(int? page)
        {
            if (page < 1)
            {
                return null;
            }

            var inputViewModel = _accountService.GetInputViewModel();

            var listPaged = inputViewModel.ToPagedList(page ?? 1, PageSize);

            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;
            
            return listPaged;
        }

        [HttpPost]
        public ActionResult Submit(InputViewModel inputViewModel)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(inputViewModel);
                _accountService.Save();
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