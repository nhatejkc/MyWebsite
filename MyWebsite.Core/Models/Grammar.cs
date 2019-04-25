using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class Grammar
    {
        public int Id { get; set; }
        public int LessionId { get; set; }
        [ForeignKey("LessionId")]
        public virtual Lession Lession { get; set; }
        [Required(ErrorMessage = "GrammarShortDescription  is required.")]
        public string GrammarShortDescription { get; set; }
        [Required(ErrorMessage = "GrammarDescription is required.")]
        public string GrammarDescription { get; set; }
        public DateTime PostOn { get; set; }
        public DateTime? Modifie { get; set; }
    }
}
