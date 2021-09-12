using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;
using Homework_SkillTree.Enums;

namespace Homework_SkillTree.Models
{
    public class RecordInputViewModel
    {
        [Required]
        [DisplayName("類別")]
        public EnumCategory Category { get; set; }

        [Required]
        [DisplayName("金額")]
        public int Money { get; set; }

        [Remote("CheckDate", "Home")]
        [Required]
        [DisplayName("日期")]
        // [DateBefore]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        [StringLength(100)]
        [DisplayName("備註")]
        public string Description { get; set; }
    }

    public class DateBeforeAttribute : ValidationAttribute
    {
        private DateTime _date;

        public DateBeforeAttribute()
        {
            _date = DateTime.Today;
        }

        public override bool IsValid(object value)
        {
            var date = (DateTime)value;
            return date <= _date.Date;
        }

        public override string FormatErrorMessage(string name)
        {
            return "123123";
        }
    }
}