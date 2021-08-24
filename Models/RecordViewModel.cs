using System.Collections.Generic;
using Homework_SkillTree.Controllers;

namespace Homework_SkillTree.Models
{
    public class RecordViewModel
    {
        public RecordInputViewModel InputViewModel { get; set; }
        public List<RecordInputViewModel> DisplayViewModel { get; set; }
    }
}