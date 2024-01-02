using Infinite_LMS_NETCore_MVC.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite_LMS_NETCore_MVC.Entity
{
    public class MediaType:IPrimaryProperties
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200,MinimumLength =2)]
        public string Title { get; set; }
        [Required]

        public string ThumbnailImagepath { get; set; }
        [ForeignKey("MediaTypeId")]
        public ICollection<CategoryItem> CategoryItems { get; set; }

    }
}
