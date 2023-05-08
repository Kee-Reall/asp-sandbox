using System.ComponentModel.DataAnnotations;
using BlogPlatform.Utils.Atribute;

namespace BlogPlatform.Models
{
    public class BlogInput : IBlogInput
    {
        [Required]
        [StringLength(15)]
        public string name { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }

        [CustomUrl]
        public string websiteUrl { get; set; }
    }
}
