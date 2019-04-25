using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class SoundConservation
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public virtual Actor Actor { get; set; }
        public int LessionId { get; set; }
        [ForeignKey("LessionId")]
        public virtual Lession Lession { get; set; }
        [Required(ErrorMessage = "VietNamese is required.")]
        public string VietNamese { get; set; }
        [Required(ErrorMessage = "Japanese is required.")]
        public string Japanese { get; set; }
        [Required(ErrorMessage = "Romaji is required.")]
        public string Romaji { get; set; }
        public DateTime PostOn { get; set; }
        public DateTime? Modifie { get; set; }
    }
}
