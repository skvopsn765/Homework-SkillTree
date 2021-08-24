using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Homework_SkillTree.Models
{
    public enum EnumCategory
    {
        [Display(Name = "請選擇")]
        Default,
        
        [Display(Name = "收入")]
        Income,
        
        [Display(Name = "支出")]
        Outcome,
    }
    public class MoneyRecordViewModel
    {
        [DisplayName("類別")]
        public EnumCategory Category { get; set; }
        
        [DisplayName("金額")]
        public string Money { get; set; }
        
        [DisplayName("日期")]
        public string Date { get; set; }
        
        [DisplayName("備註")]
        public string Description { get; set; }
    }
    
    
}