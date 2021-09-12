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

        public ActionResult Index()
        {
            var recordViewModel = _accountService.GetRecordViewModel();
            return View(recordViewModel);
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

        [HttpPost]
        public ActionResult Submit(RecordInputViewModel inputViewModel)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(inputViewModel);
            }

            return RedirectToAction("Index");
        }
    }
}