﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BullyBooKWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100")]
        public string displayOrder { get; set; }
        public DateTime CreatedDateTime {  get; set; } = DateTime.Now;
    }
}
