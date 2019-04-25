using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Actor name is required.")]
        public string JPName { get; set; }
        [Required(ErrorMessage = "Actor name is required.")]
        public string ENName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime PostOn { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? Modifie { get; set; }
        public virtual IList<SoundConservation> SoundConservations { get; set; }
    }
}
