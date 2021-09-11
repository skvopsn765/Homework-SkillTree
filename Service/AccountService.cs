using System.Linq;
using Homework_SkillTree.Enums;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Service
{
    public class AccountService
    {
        public RecordViewModel GetRecordViewModel()
        {
            var model1 = new Model1();
            var accountBooks = model1.AccountBook.ToList();
            var recordViewModel = new RecordViewModel
            {
                DisplayViewModel = accountBooks.Select(x => new RecordInputViewModel()
                {
                    Category = (EnumCategory)x.Categoryyy,
                    Date = x.Dateee,
                    Description = x.Remarkkk,
                    Money = x.Amounttt
                }).ToList(),
            };
            return recordViewModel;
        }
    }
}