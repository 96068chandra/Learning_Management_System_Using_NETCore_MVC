using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite_LMS_NETCore_MVC.Entity
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250,MinimumLength =2)]
        public string Title { get; set; }

        public string HtmlContent { get; set; }

        public string VideoLink { get; set; }
        
   
        public CategoryItem CategoryItem { get; set; }
        [NotMapped]
        public int CatItemId { get; set; }
        [NotMapped]
        public int CategoryId { get; set; }

    }
}
