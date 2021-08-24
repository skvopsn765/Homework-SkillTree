using System.ComponentModel.DataAnnotations;

namespace Homework_SkillTree.Enums
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
}