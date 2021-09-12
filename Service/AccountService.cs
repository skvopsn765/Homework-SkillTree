using System;
using System.Collections.Generic;
using System.Linq;
using Homework_SkillTree.Enums;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Service
{
    public class AccountService
    {
        private static readonly Model1 Model1 = new Model1();

        public RecordViewModel GetRecordViewModel()
        {
            var accountBooks = Model1.AccountBook.ToList();
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

        public void Add(RecordInputViewModel recordInputViewModel)
        {
            Model1.AccountBook.Add(new AccountBook()
            {
                Id = Guid.NewGuid(),
                Amounttt = recordInputViewModel.Money,
                Categoryyy = (int)recordInputViewModel.Category,
                Dateee = recordInputViewModel.Date,
                Remarkkk = recordInputViewModel.Description
            });
            Model1.SaveChanges();
        }
    }
}