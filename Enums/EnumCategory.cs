using System.ComponentModel.DataAnnotations;

namespace Homework_SkillTree.Enums
{
    public enum EnumCategory
    {
        [Display(Name = "Default")]
        Default,
        
        [Display(Name = "Income")]
        Income,
        
        [Display(Name = "Outcome")]
        Outcome,
    }
}