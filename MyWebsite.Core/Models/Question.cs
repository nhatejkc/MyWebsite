using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebsite.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "MainConent is required.")]
        public string QuestionTitle { get; set; }
        [Required(ErrorMessage = "Answer is required.")]
        public string Answer { get; set; }
        public virtual IList<QuestionItem> QuestionItems { get; set; }
        public int TopicId { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}
