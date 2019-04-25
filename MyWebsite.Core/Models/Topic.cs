using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class Topic
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "TopicTitle is required.")]
        public string TopicTitle { get; set; }

        public virtual IList<Question> Questions { get; set; }
    }
}
