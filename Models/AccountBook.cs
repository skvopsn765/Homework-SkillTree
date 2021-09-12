namespace Homework_SkillTree.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AccountBook")]
    public class AccountBook
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public int Categoryyy { get; set; }

        [Required]
        public int Amounttt { get; set; }

        [Required]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarkkk { get; set; }
    }
}