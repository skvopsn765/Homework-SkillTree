using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Homework_SkillTree.Enums;

namespace Homework_SkillTree.Models
{
    public class RecordInputViewModel
    {
        [DisplayName("類別")]
        public EnumCategory Category { get; set; }
        
        [DisplayName("金額")]
        public int Money { get; set; }
        
        [DisplayName("日期")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [DisplayName("備註")]
        public string Description { get; set; }
    }
    
    
}