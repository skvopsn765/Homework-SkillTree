using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        
        [Required]
        [DisplayName("日期")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [Required]
        [DisplayName("備註")]
        public string Description { get; set; }
    }
    
    
}