using System;
using System.Linq;
using Homework_SkillTree.Enums;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Service
{
    public class AccountService
    {
        private static Model1 _model1;

        public AccountService(Model1 model1)
        {
            _model1 = model1;
        }

        public RecordViewModel GetRecordViewModel()
        {
            if (_model1.AccountBook is null)
            {
                return null;
            }
            var accountBooks = _model1.AccountBook.ToList();
            return new RecordViewModel
            {
                DisplayViewModel = accountBooks.Select(x => new RecordInputViewModel()
                {
                    Category = (EnumCategory)x.Categoryyy,
                    Date = x.Dateee,
                    Description = x.Remarkkk,
                    Money = x.Amounttt
                }).OrderByDescending(x=>x.Date).ToList(),
            };
        }

        public void Add(RecordInputViewModel recordInputViewModel)
        {
            _model1.AccountBook.Add(new AccountBook()
            {
                Id = Guid.NewGuid(),
                Amounttt = recordInputViewModel.Money,
                Categoryyy = (int)recordInputViewModel.Category,
                Dateee = recordInputViewModel.Date,
                Remarkkk = recordInputViewModel.Description
            });
            _model1.SaveChanges();
        }
    }
}