using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite_LMS_NETCore_MVC.Entity
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int MediaTypeId { get; set; }

    
        public CategoryItem()
        {
            MediaTypes=new List<SelectListItem>();
           
        }

        [NotMapped]

        public virtual ICollection<SelectListItem> MediaTypes {  get; set; }

        public DateTime DateTimeItemReleased { get; set; }

    }
}
