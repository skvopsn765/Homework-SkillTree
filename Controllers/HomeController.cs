using System;
using System.Linq;
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

        [Route("skilltree")]
        [Route("skilltree/{year:length(4)}/{month:length(2)}")]
        public ActionResult SkillTree(InputViewModel inputViewModel, int? year, int? month)        {
            ViewBag.Year = year;
            ViewBag.Month = month;
            return View(inputViewModel);
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult ShowRecord(int? year, int? month, int page = 1)
        {
            ViewBag.Year = year;
            ViewBag.Month = month;
            var pagedRecord = GetPagedRecord(year, month, page);
            return View(pagedRecord);
        }

        private object GetPagedRecord(int? year, int? month, int? page)
        {
            if (page < 1)
            {
                return null;
            }

            var inputViewModel = _accountService.GetInputViewModel();
            if (year != null && month != null)
            {
                inputViewModel = inputViewModel.Where(x => x.Date.Year == year && x.Date.Month == month).ToList();
            }

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
                return RedirectToAction("SkillTree");
            }

            return RedirectToAction("SkillTree", inputViewModel);
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

        public ActionResult CheckDate(DateTime? date, string useless)
        {
            if (date <= DateTime.Today.Date)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json("日期不可以超過今天！", JsonRequestBehavior.AllowGet);
        }
    }
}