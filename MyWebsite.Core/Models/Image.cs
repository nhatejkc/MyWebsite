using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebsite.Core.Models
{
    public class Image
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Links is required.")]
        public string ImgLink { get; set; }
        public int LessionId { get; set; }
        [ForeignKey("LessionId")]
        public virtual Lession Lession { get; set;}
    }
}
