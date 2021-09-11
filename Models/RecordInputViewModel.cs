﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DateTime Date { get; set; }
        
        [DisplayName("備註")]
        public string Description { get; set; }
    }
    
    
}