using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public List<InputViewModel> GetInputViewModel()
        {
            if (_model1.AccountBook is null)
            {
                return null;
            }

            var accountBooks = _model1.AccountBook.ToList();
            return accountBooks.Select(x => new InputViewModel
            {
                Category = (EnumCategory)x.Categoryyy,
                Date = x.Dateee,
                Description = x.Remarkkk,
                Money = x.Amounttt.ToString()
            }).OrderByDescending(x => x.Date).ToList();
        }

        public void Add(InputViewModel inputViewModel)
        {
            _model1.AccountBook.Add(new AccountBook()
            {
                Id = Guid.NewGuid(),
                Amounttt = Convert.ToInt32(inputViewModel.Money),
                Categoryyy = (int)inputViewModel.Category,
                Dateee = inputViewModel.Date,
                Remarkkk = inputViewModel.Description
            });
        }

        public void Save()
        {
            try { 
                _model1.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var entityError = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var getFullMessage = string.Join("; ", entityError);
                var exceptionMessage = string.Concat(ex.Message, "errors are: ", getFullMessage);
            }
        }
    }
}