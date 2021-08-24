using System.ComponentModel;

namespace Homework_SkillTree.Models
{
    public class MoneyRecordViewModel
    {
        [DisplayName("類別")]
        public string Category { get; set; }
        
        [DisplayName("金額")]
        public string Money { get; set; }
        
        [DisplayName("日期")]
        public string Date { get; set; }
        
        [DisplayName("備註")]
        public string Description { get; set; }
    }
}