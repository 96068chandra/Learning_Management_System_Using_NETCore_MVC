﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite_LMS_NETCore_MVC.Entity
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
        public Category()
        {
            CategoryItems = new List<CategoryItem>();
            UserCategory = new List<UserCategory>();
        }
        [ForeignKey("CategoryId")]
        public ICollection <CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }



    }
}
