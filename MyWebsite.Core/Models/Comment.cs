using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserComment { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentTime { get; set; }
        
        public int? LessionId { get; set; }
        [ForeignKey("LessionId")]
        public virtual Lession Lession { get; set; }
        public int? TopicId { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }

    }
}
