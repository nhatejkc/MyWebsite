using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebsite.Core.Models
{
    public class Lession
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "MainConent is required.")]
        public string MainConent { get; set; }
        [Required(ErrorMessage = "SoundLession is required.")]
        public string SoundLession { get; set; }
        [Required(ErrorMessage = "Sound is required.")]
        public string Sound { get; set; }
        [Required(ErrorMessage = "LessionShortDescription is required.")]
        public string LessionShortDescription { get; set; }
        public DateTime PostOn { get; set; }
        public DateTime? Modifie { get; set; }
        [Required(ErrorMessage = "Images is required.")]
        public string Images { get; set; }
        public virtual IList<Grammar> Grammars { get; set; }
        public virtual IList<SoundConservation> SoundConservations { get; set; }
    }
}
