using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Homework_SkillTree.Enums;
using Homework_SkillTree.Filters;

namespace Homework_SkillTree.Models
{
    public class RecordInputViewModel
    {
        [Required]
        [DisplayName("類別")]
        public EnumCategory Category { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [DisplayName("金額")]
        public string Money { get; set; }

        [RemoteDoublePlus("CheckDate", "Home","")]
        [Required]
        [DisplayName("日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        [StringLength(100)]
        [DisplayName("備註")]
        public string Description { get; set; }
    }
}